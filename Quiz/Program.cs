using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz.Model;

namespace Quiz.Model
{
    
    static class Program
    {
        private static Database db = new Database();
        public static List<User> UserList = db.Users.ToList();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Default());
        }
    }
}
