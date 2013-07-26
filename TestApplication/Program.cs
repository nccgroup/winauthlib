using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinAuth;

namespace TestApplication
{
    static class Program
    {

                        /* will not work like this and will throw a compiler error
                         * this needs to be placed at the very start of the application entry point in order 
                         * for the DCOM auth functionality to work.
                         * 
                         * Also the "Visual Studio Hosting Process" Needs To Be Turned off!!
                         * GO TO Project -> Properties (Bottom Item) -> Debug Options
                         *    ****YOU WILL GET A RUNTIME ERROR OTHERWISE****
                         */
  
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DCOMAuth.CoInitializeSecurity(IntPtr.Zero, -1, IntPtr.Zero, IntPtr.Zero, (uint)DCOMAuth.RpcAuthnLevel.Connect, (uint)DCOMAuth.RpcImpLevel.Impersonate, IntPtr.Zero, (uint)DCOMAuth.EoAuthnCap.DynamicCloaking, IntPtr.Zero);                        
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
