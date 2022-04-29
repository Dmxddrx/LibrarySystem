using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartUpPage());
            Application.Run(new SignUp());
            Application.Run(new Dashboard());
            Application.Run(new AddBook());
            Application.Run(new ViewBook());
            Application.Run(new AddStudent());
            Application.Run(new ViewStudent());
            Application.Run(new IssueBook());
            Application.Run(new ReturnBook());
            Application.Run(new CompleteBookDetails());
            Application.Run(new ChangePassword());


        }
    }
}
