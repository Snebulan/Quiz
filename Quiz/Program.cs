using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //Application.Run(new ListStuff());
        }

        // Test users password
        public static bool TestPassword(User user, string password)
        {
            return user.Password == CreateMD5(password, user.Salt);
        }

        // Create salt for MD5
        public static string CreateSalt()
        {
            Random rnd = new Random();
            int saltInt = rnd.Next(1000000, 9999999);
            return saltInt.ToString();
        }
        
        // Create a secure password
        public static string CreatePassword(string inputPassword, string salt)
        {
            return CreateMD5(inputPassword, salt);
        }

        // Encode Password with MD5
        public static string CreateMD5(string input, string salt)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(salt + input); // With Salt
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}