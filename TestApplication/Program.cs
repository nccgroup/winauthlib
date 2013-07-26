using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
