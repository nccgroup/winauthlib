using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace WinAuth
{

    /* ########################################################################################
      *                       Remote DCOM/SMB Authentication Library
      *               ***USE IF ATTEMPTING TO ACCESS REMOTE COM COMPONENTS***
      *                  
      *                   Author: Chris Thomas, chris dot thomas at nccgroup dot com
      * ########################################################################################
      * 
      * Version 1.0 (24th April 2013)
      * + Initial Release
      * 
      * 
      *      Released as open source by NCC Group Plc - http://www.nccgroup.com/
      *
      *      Developed by Chris Thomas, chris dot thomas at nccgroup dot com
      *
      *      https://github.com/nccgroup/winauthlib
      *
      *      Released under AGPL see LICENSE for more information
      * 
      */

    public class DCOMAuth
    {

        /// <summary>
        /// Is The User Authenticated
        /// </summary>
        public Boolean isAuthenticated {
            get { return this._isAuthenticated; }
            set { this._isAuthenticated = value; }
        }
        
        private WindowsImpersonationContext _ImpersonatedUser = null;
        private Boolean _isAuthenticated = false;

        #region DLL References
                //http://msdn.microsoft.com/en-us/library/windows/desktop/aa378184(v=vs.85).aspx
                [DllImport("advapi32.dll", SetLastError = true)]
                private static extern Boolean LogonUser(String lpszUsername, String lpszDomain, String lpszPassword, UInt32 dwLogonType, UInt32 dwLogonProvider, ref IntPtr Token);

                //http://msdn.microsoft.com/en-us/library/windows/desktop/aa378612(v=vs.85).aspx
                [DllImport("advapi32.dll", EntryPoint = "ImpersonateLoggedOnUser", SetLastError = true)]
                public static extern Boolean ImpersonateLoggedOnUser(IntPtr hToken);

                //http://msdn.microsoft.com/en-us/library/ms724211(v=vs.85).aspx
                [DllImport("kernel32.dll", SetLastError = true)]
                private static extern Boolean CloseHandle(IntPtr handle);

                //http://msdn.microsoft.com/en-us/library/ms693736(v=vs.85).aspx
                [DllImport("Ole32.dll", ExactSpelling = true, EntryPoint = "CoInitializeSecurity", CallingConvention = CallingConvention.StdCall, SetLastError = false, PreserveSig = false)]
                public static extern void CoInitializeSecurity(
                                                                IntPtr pSecDesc,
                                                                Int32 cAuthSvc,
                                                                IntPtr asAuthSvc,
                                                                IntPtr pReserved1,
                                                                UInt32 dwAuthnLevel,
                                                                UInt32 dwImpLevel,
                                                                IntPtr pAuthList,
                                                                UInt32 dwCapabilities,
                                                                IntPtr pReserved3);

                //http://msdn.microsoft.com/en-us/library/windows/desktop/ms678543(v=vs.85).aspx
                [DllImport("ole32.dll")]
                private static extern Int32 CoInitialize(IntPtr pvReserved);

        #endregion


        #region Structures
                    public enum LogOnProvider
                    {
                        /// <summary>
                        ///     Use the default logon provider.  This is equivalent to the LOGON32_PROVIDER_DEFAULT provider.
                        /// </summary>
                        Default = 0,

                        /// <summary>
                        ///     Use the NTLM logon provider.  This is equivalent to the LOGON32_PROVIDER_WINNT40 provider.
                        /// </summary>
                        WinNT40 = 2,

                        /// <summary>
                        ///     Use the negotiate logon provider.  This is equivalent to the LOGON32_PROVIDER_WINNT50 provider.
                        /// </summary>
                        WinNT50 = 3,

                        /// <summary>
                        ///     Use the virtual logon provider.  This is equivalent to the LOGON32_PROVIDER_VIRTUAL provider.
                        /// </summary>
                        Virtual = 4,


                    }

                    public enum LogOnType
                    {
                        /// <summary>
                        ///     No logon type - this is not a valid logon type to use with LogonUser
                        /// </summary>
                        None = 0,

                        /// <summary>
                        ///     Logon as an interactive user, which may cause additional caching and therefore not be
                        ///     appropriate for some server scenarios.  This is equivalent to the LOGON32_LOGON_INTERACTIVE
                        ///     logon type.
                        /// </summary>
                        Interactive = 2,

                        /// <summary>
                        ///     Logon type for servers to check cleartext passwords.  No caching is done for this type of
                        ///     logon.  This is equivalent to the LOGON32_LOGON_NETWORK logon type.
                        /// </summary>
                        Network = 3,

                        /// <summary>
                        ///     Logon type for servers who act on behalf of users without their intervention, or who
                        ///     processs many cleartext passwords at time.  This is equivalent to the LOGON32_LOGON_BATCH
                        ///     logon type.
                        /// </summary>
                        Batch = 4,

                        /// <summary>
                        ///     Logon as a service.  The account being logged on must have privilege to act as a service. 
                        ///     This is equivalent to the LOGON32_LOGON_SERVICE logon type.
                        /// </summary>
                        Service = 5,

                        /// <summary>
                        ///     Logon type for GINA DLLs to unlock the machine with.  This is equivalent to the
                        ///     LOGON32_LOGON_UNLOCK logon type.
                        /// </summary>
                        Unlock = 7,

                        /// <summary>
                        ///     Logon type which allows caching of the text password in the authentication provider in order
                        ///     to allow connections to multiple network services with the same credentials.  This is
                        ///     equivalent to the LOGON32_LOGON_NETWORK_CLEARTEXT logon type.
                        /// </summary>
                        NetworkClearText = 8,

                        /// <summary>
                        ///     Logon type which creates a token with the same identity as the current user token for the
                        ///     local proces, but provides new credentials for outbound network connections.  This is
                        ///     equivalent to the LOGON32_LOGON_NEW_CREDENTIALS logon type.
                        ///</summary>
                        NewCredentials = 9,
                    }


                    public enum RpcAuthnLevel
                    {
                        Default = 0,
                        None,
                        /// <summary>
                        ///     authenticate only when the TCP conn is first established
                        /// </summary>
                        Connect,
                        /// <summary>
                        ///     not implemented and elevates to pkt
                        /// </summary>
                        Call, 
                        /// <summary>
                        ///     MAC protect headers of each fragment og each call
                        /// </summary>
                        Pkt,
                        /// <summary>
                        ///     MAC protect the payload
                        /// </summary>
                        PktIntegrity,
                        /// <summary>
                        ///     all payloads (not headers) are encrypted
                        /// </summary>
                        PktPrivacy 
                    }

                    public enum RpcImpLevel
                    {
                        Default = 0,
                        /// <summary>
                        ///     useless for remote stuff
                        /// </summary>
                        Anonymous, 
                        /// <summary>
                        ///     useless for remote stuff
                        /// </summary>
                        Identify,
                        /// <summary>
                        ///     (normal setting)
                        /// </summary>
                        Impersonate,
                        /// <summary>
                        ///     happy to send your network creds to the server if its trusted for delegation
                        /// </summary>
                        Delegate 
                    }

                    //CoInitializeSecurity Capabilities
                    //http://msdn.microsoft.com/en-us/library/ms693368%28VS.85%29.aspx
                    public enum EoAuthnCap
                    {
                        /// <summary>
                        ///     Indicates that no capability flags are set.
                        /// </summary>
                        None = 0x00,

                        /// <summary>
                        ///     If this flag is specified, it will be ignored. Support for mutual 
                        ///     authentication is automatically provided by some authentication services
                        /// </summary>
                        MutualAuth = 0x01,

                        /// <summary>
                        ///     Sets static cloaking. When this flag is set, DCOM uses the thread token 
                        ///     (if present) when determining the client's identity. However, the client's 
                        ///     identity is determined on the first call on each proxy (if SetBlanket is not 
                        ///     called) and each time CoSetProxyBlanket is called on the proxy.
                        /// </summary>
                        StaticCloaking = 0x20,

                        /// <summary>
                        ///     Sets dynamic cloaking. When this flag is set, DCOM uses the thread token 
                        ///     (if present) when determining the client's identity. On each call to a proxy,
                        ///     the current thread token is examined to determine whether the client's identity
                        ///     has changed (incurring an additional performance cost) and the client is 
                        ///     authenticated again only if necessary. Dynamic cloaking can be set by clients only.
                        /// </summary>
                        DynamicCloaking = 0x40,

                        /// <summary>
                        ///     This flag is obsolete.
                        /// </summary>
                        AnyAuthority = 0x80,

                        /// <summary>
                        ///     Causes DCOM to send Schannel server principal names in fullsic format to clients 
                        ///     as part of the default security negotiation. The name is extracted from the server certificate.
                        /// </summary>
                        MakeFullSIC = 0x100,

                        /// <summary>
                        ///     Tells DCOM to use the valid capabilities from the call to CoInitializeSecurity. 
                        ///     If CoInitializeSecurity was not called, EOAC_NONE will be used for the capabilities
                        ///     flag. This flag can be set only by clients in a call to IClientSecurity::SetBlanket 
                        ///     or CoSetProxyBlanket.
                        /// </summary>
                        Default = 0x800,

                        /// <summary>
                        ///     Authenticates distributed reference count calls to prevent malicious users from 
                        ///     releasing objects that are still being used. If this flag is set, which can be 
                        ///     done only in a call to CoInitializeSecurity by the client, the authentication 
                        ///     level (in dwAuthnLevel) cannot be set to none.
                        /// </summary>
                        SecureRefs = 0x02,

                        /// <summary>
                        ///     Indicates that the pSecDesc parameter to CoInitializeSecurity is a pointer to 
                        ///     an IAccessControl interface on an access control object. When DCOM makes security 
                        ///     checks, it calls IAccessControl::IsAccessAllowed. This flag is set only by the server.
                        /// </summary>
                        AccessControl = 0x04,

                        /// <summary>
                        ///     Indicates that the pSecDesc parameter to CoInitializeSecurity is a pointer to a 
                        ///     GUID that is an AppID. The CoInitializeSecurity function looks up the AppID in the 
                        ///     registry and reads the security settings from there. If this flag is set, all other 
                        ///     parameters to CoInitializeSecurity are ignored and must be zero. Only the server can 
                        ///     set this flag. 
                        /// </summary>
                        AppID = 0x08,

                        /// <summary>
                        ///     Reserved.
                        /// </summary>
                        Dynamic = 0x10,

                        /// <summary>
                        ///     Causes DCOM to fail CoSetProxyBlanket calls where an Schannel principal name is specified 
                        ///     in any format other than fullsic. This flag is currently for clients only. 
                        /// </summary>
                        RequireFullSIC = 0x200,

                        /// <summary>
                        ///     Reserved.
                        /// </summary>
                        AutoImpersonate = 0x400,

                        /// <summary>
                        ///     Specifying this flag helps protect server security when using DCOM or COM+. It reduces the 
                        ///     chances of executing arbitrary DLLs because it allows the marshaling of only CLSIDs that are 
                        ///     implemented in Ole32.dll, ComAdmin.dll, ComSvcs.dll, or Es.dll, or that implement the 
                        ///     CATID_MARSHALER category ID. Any service that is critical to system operation should set this flag.
                        /// </summary>
                        NoCustomMarshal = 0x2000,

                        /// <summary>
                        ///     Causes any activation where a server process would be launched under the caller's identity 
                        ///     (activate-as-activator) to fail with E_ACCESSDENIED. This value, which can be specified only in 
                        ///     a call to CoInitializeSecurity by the client, allows an application that runs under a privileged 
                        ///     account (such as LocalSystem) to help prevent its identity from being used to launch untrusted components.
                        /// </summary>
                        DisableAAA = 0x1000
                    }
        #endregion
    
    
    
        #region Methods
                        /// <summary>
                        /// 
                        /// </summary>
                        /// <param name="username"></param>
                        /// <param name="password"></param>
                        /// <param name="domain"></param>
                        /// <param name="logontype"></param>
                        /// <param name="provider"></param>
                        /// <returns></returns>
                        public Int32 Authenticate(String username, String password, String domain, LogOnType logontype, LogOnProvider provider)
                        {
                         
                            
                            WindowsIdentity _NewId = null;
                            IntPtr _Token = IntPtr.Zero;

                            try
                            {
                                //logon and store the creds in "token"
                                Boolean _Result = LogonUser(username, domain, password, (UInt32)logontype, (UInt32)provider, ref _Token);

                                //did the login fail?
                                if (!_Result) { return Marshal.GetLastWin32Error(); }
                                else
                                {
                                    //load the token into a WindowsIdentity
                                    _NewId = new WindowsIdentity(_Token, "LogonUser", WindowsAccountType.Normal, true);
                                    _ImpersonatedUser = _NewId.Impersonate();

                                    this._isAuthenticated = true;
                                    return 0;                                    
                                }//end of if-else
                            }
                            catch (Exception) { throw; }
                            finally
                            {
                                //clear the token
                                if (_Token != IntPtr.Zero) { CloseHandle(_Token); }
                            }
                        }//end of Authenticate

                        public void LogOffUser() {

                            //Are we authenticated?
                            if (!this.isAuthenticated) { return; }
                            
                                _ImpersonatedUser.Undo();
                                this.isAuthenticated = false;                            
                        }



                        /* will not work like this and will throw a compiler error
                         * this needs to be placed at the very start of the application entry point in order 
                         * for the DCOM auth functionality to work.
                         * 
                         * Also the "Visual Studio Hosting Process" Needs To Be Turned off!!
                         * GO TO Project -> Properties (Bottom Item) -> Debug Options
                         *    ****YOU WILL GET A RUNTIME ERROR OTHERWISE****
                         *    
                         * e.g.
                         *         [STAThread]
                                    static void Main()
                                    {
                                        CoInitializeSecurity(IntPtr.Zero, -1, IntPtr.Zero, IntPtr.Zero, (uint)DCOMAuth.RpcAuthnLevel.Connect, (uint)DCOMAuth.RpcImpLevel.Impersonate, IntPtr.Zero, (uint)DCOMAuth.EoAuthnCap.DynamicCloaking, IntPtr.Zero);                        

                                        Application.EnableVisualStyles();
                                        Application.SetCompatibleTextRenderingDefault(false);
                                        Application.Run(new MainForm());
                         * 
                         */

                        public static void SetupCoInitializeSecurity()
                        {
                            // Initialize COM security for the process specifying impersonate a user for outgoing function calls
                            CoInitializeSecurity(IntPtr.Zero, -1, IntPtr.Zero, IntPtr.Zero, (uint)RpcAuthnLevel.Connect, (uint)RpcImpLevel.Impersonate, IntPtr.Zero, (uint)EoAuthnCap.DynamicCloaking, IntPtr.Zero);
                        }

        #endregion    
    
    }
}
