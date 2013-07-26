using System;
using System.Windows.Forms;
using WUApiLib; // Windows Update Library
                //C:\Windows\System32\wuapi.dll

using WinAuth; //our DLL with the authentication classes

/*
 * 
 *      Released as open source by NCC Group Plc - http://www.nccgroup.com/
 *
 *      Developed by Chris Thomas, chris dot thomas at nccgroup dot com
 *
 *      https://github.com/nccgroup/winauthlib
 *
 *      Released under AGPL see LICENSE for more information
 */

namespace TestApplication
{
    public partial class MainForm : Form
    {
        private Boolean isDCOMAuthenicated = false;
        private Boolean isWNetAuthenticated = false;

        //these values are to track whether the use has changed any of the 
        //authentication options and whether the app has to re-authenticate.
        private String TargetHost = String.Empty;
        Int32 LogonProviderIndex = -1;
        Int32 LogOnTypeIndex = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //setup default values for form objects
            WNetAuthRadioButton.Checked = true;
            LogonProviderCombo.SelectedIndex = 0;
            LogOnTypeComboBox.SelectedIndex = 7;
            RootKeyCombo.SelectedIndex = 2;
        }

        private void WNetAuthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //is DCOM ticked? enable its option components
            Boolean _Value = true;

            if (WNetAuthRadioButton.Checked)
            {
                _Value = false;
            }

            LogonProviderCombo.Enabled = _Value;
            LogOnTypeComboBox.Enabled = _Value;
        }


        private Int32 PerformAuthentication()
        {
            //is the target the same as last time?
            if (TargetHost.Equals(TargetTextBox.Text.Trim()))
            {
                //were already authenticated
                if ((WNetAuthRadioButton.Checked) && (isWNetAuthenticated == true)) { return 0; }
                if ((DCOMAuthRadioButton.Checked) && (isDCOMAuthenicated == true)) { return 0; }
            }
            else
            {
                isWNetAuthenticated = false;
                isDCOMAuthenicated = false;
            }//end of if-else (TargetHost.Equals(TargetTextBox.Text.Trim()))

            if ((WNetAuthRadioButton.Checked) && (isWNetAuthenticated == false))
            {
                WNetAuth _wnetAuth = new WNetAuth();

                WNetAuth.SMB_RESULT_CODE _Result = WNetAuth.SMB_RESULT_CODE.UNKNOWN;

               _Result = _wnetAuth.MapIPCDrive(DomainTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text, TargetTextBox.Text);
               if (_Result == WNetAuth.SMB_RESULT_CODE.AUTH_SUCCESS)
               {                   
                   isWNetAuthenticated = true;
                   return 0;
               }
               else
               {
                   return (Int32) _Result;
               }
            }
            else if ((WNetAuthRadioButton.Checked) && (isWNetAuthenticated == true)) // are we already authenticated.
            {
                return 0; 
            }//end of if-else ((WNetAuthRadioButton.Checked) && (isWNetAuthenticated == false))
            
            

            if ((DCOMAuthRadioButton.Checked) && (isDCOMAuthenicated == false))
            {
                DCOMAuth.LogOnProvider _LogonProvider = DCOMAuth.LogOnProvider.Default;
                DCOMAuth.LogOnType _LogonType = DCOMAuth.LogOnType.Network;

                switch (LogOnTypeComboBox.SelectedIndex)
                {
                    case 0: _LogonType = DCOMAuth.LogOnType.None;
                        break;
                    case 1: _LogonType = DCOMAuth.LogOnType.Interactive;
                        break;
                    case 2: _LogonType = DCOMAuth.LogOnType.Network;
                        break;
                    case 3: _LogonType = DCOMAuth.LogOnType.Batch;
                        break;
                    case 4: _LogonType = DCOMAuth.LogOnType.Service;
                        break;
                    case 5: _LogonType = DCOMAuth.LogOnType.Unlock;
                        break;
                    case 6: _LogonType = DCOMAuth.LogOnType.NetworkClearText;
                        break;
                    case 7: _LogonType = DCOMAuth.LogOnType.NewCredentials;
                        break;
                    default: _LogonType = DCOMAuth.LogOnType.NewCredentials; // this option is required for remote auth so its the default.
                        break;
                }//end of switch

                switch (LogonProviderCombo.SelectedIndex)
                {
                    case 0: _LogonProvider = DCOMAuth.LogOnProvider.Default;
                        break;
                    case 1: _LogonProvider = DCOMAuth.LogOnProvider.WinNT40;
                        break;
                    case 2: _LogonProvider = DCOMAuth.LogOnProvider.WinNT50;
                        break;
                    case 3: _LogonProvider = DCOMAuth.LogOnProvider.Virtual;
                        break;
                    default: _LogonProvider = DCOMAuth.LogOnProvider.Default;
                        break;
                }

                DCOMAuth _DCOMAuth = new DCOMAuth();

                Int32 _Result = _DCOMAuth.Authenticate(UsernameTextBox.Text, PasswordTextBox.Text, DomainTextBox.Text, _LogonType, _LogonProvider);

                //did we auth ok? 
                if (_Result == 0)
                {
                    //we need to record the auth options just in case the change and we have to re-authenticate.
                    this.LogOnTypeIndex = LogOnTypeComboBox.SelectedIndex;
                    this.LogonProviderIndex = LogonProviderCombo.SelectedIndex;

                    isDCOMAuthenicated = true;
                    return 0;
                }
                else
                {
                    return _Result;
                }//end of if-else (_Result == 0)

            }
            else if ((DCOMAuthRadioButton.Checked) && (isDCOMAuthenicated == true)) // are we already authenticated?
            {
                //are the DCOM options the same as lasttime?
                if ((LogonProviderIndex == LogonProviderCombo.SelectedIndex) && (LogOnTypeIndex == LogOnTypeComboBox.SelectedIndex))
                {
                    return 0;
                }
                else // one of the options has changed so we need to re-authenticate
                {
                    //we need to re-authenticate
                    this.isDCOMAuthenicated = false;
                    //recursivley call the auth method to go through the auth process again
                    return PerformAuthentication();
                }
            }//end of if ((DCOMAuthRadioButton.Checked) && (isDCOMAuthenicated == false))

            //default catch all
            return -1;
        }

        private void TestRegistryKeyButton_Click(object sender, EventArgs e)
        {
            //remove any
            RegKeyReadtextBox.Clear();

            Int32 _AuthResult = PerformAuthentication();

            //was authentication sucessful
            if (_AuthResult == 0)
            {
                RegKeyReadtextBox.Text = "Sucessfully Authenticated!\n";
            }
            else
            {
                RegKeyReadtextBox.Text = String.Format("Authentication Failed With SMB Code '{0}'", _AuthResult);

                //we cant do anything so break out and end the method.
                return;
            }//end of if-else (_AuthResult == 0)

            try
            {

            }
            catch (Exception ex)
            {
                RegKeyReadtextBox.Text = String.Format("An Exception Occured!\nException Message:\n{0}", ex.Message);
            }//end of try-catch

        }

        private void WinUpdatesTestGOButton_Click(object sender, EventArgs e)
        {
            WinUpdateTestTextBox.Clear();

            Int32 _AuthResult = PerformAuthentication();

            //was authentication sucessful
            if (_AuthResult == 0)
            {
                WinUpdateTestTextBox.Text = "Sucessfully Authenticated!\n";
            }
            else
            {
                WinUpdateTestTextBox.Text = String.Format("Authentication Failed With SMB Code '{0}'", _AuthResult);

                //we cant do anything so break out and end the method.
                return;
            }//end of if-else (_AuthResult == 0)


            try
            {
                Type RemoteAgentInfoType = Type.GetTypeFromProgID("Microsoft.Update.AgentInfo", TargetTextBox.Text, true);
                WindowsUpdateAgentInfo RemoteAgentInfo = (WindowsUpdateAgentInfo)Activator.CreateInstance(RemoteAgentInfoType);

                String _AgentVersion = RemoteAgentInfo.GetInfo("ProductVersionString").ToString();

                WinUpdateTestTextBox.Text += String.Format("Windows Update Agent Version: '{0}'", _AgentVersion);

            }
            catch (Exception ex)
            {
                if (ex.Message.IndexOf("80070005") > -1)
                {
                    WinUpdateTestTextBox.Text += "Authentication Failed, Error 80070005\n";                    
                }
                else
                {
                    WinUpdateTestTextBox.Text += String.Format("Exception Thrown When Instantiating Windows Update DCOM!\nException:\n{0}", ex.Message);
                }//end of if-else if (ex.Message.IndexOf("80070005") > -1)
            }//end of try-catch

        }//end of method
    }
}
