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
        public static Database db = new Database();
        public static List<User> UserList = db.Users.ToList();
        public static List<Answers> AnswersList = db.Answers.ToList();
        public static List<Questions> QuestionsList = db.Questions.ToList();
        public static List<Quiz> QuizList = db.Quiz.ToList();
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AdminScreen());
            Application.Run(new Default());
            //Application.Run(new QuizScreen());
        }
    }
}
