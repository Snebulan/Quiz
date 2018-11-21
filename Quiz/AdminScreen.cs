using Quiz.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Quiz
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        // Generate password!
        private string GeneratePassword(int length)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] stringChars = new char[length];
            Random random = new Random();
            int charsL = chars.Length;

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(charsL)];
            }
            var password = new string(stringChars);
            return password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int role = 1;
            if (teacher.Checked)
            {
                role = 9;
            }
            string Pass = GeneratePassword(5);
            // Add user to db
            User newUser = new User
            {
                Name = name_text.Text,
                Email = email_text.Text,
                Role = role,
                Password = Pass,
            };
            User user = Program.UserList.FirstOrDefault(u => u.Email == email_text.Text);
            if(user != null)
            {
                MessageBox.Show("Email is already in use!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Program.UserList.Add(newUser);
                Program.db.Add(newUser);
                Program.db.SaveChanges();
                if(role == 1)
                {
                    MessageBox.Show($"Student created!\nUsername {email_text.Text}\nPassword: {Pass}", "Created",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show($"Teacher created!\nUsername {email_text.Text}\nPassword: {Pass}", "Created",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        // Add Question
        // Will add Quiz (if it doesn't exist)
        private void addQuestion_Click(object sender, EventArgs e)
        {
            Model.Quiz newQuiz = new Model.Quiz { Name = quiz.Text };
            Model.Quiz Quiz = Program.QuizList.FirstOrDefault(q => q.Name == quiz.Text);
            if(Quiz != null)
            {
                // Quiz already exists, use it
                createQuestion();
            } else
            {
                // Create Quiz
                Program.QuizList.Add(newQuiz);
                Program.db.Add(newQuiz);
                Program.db.SaveChanges();
                MessageBox.Show($"Quiz created!", "Created",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void createQuestion()
        {
            
            Questions newQuestion = new Questions { Question = question.Text };
            Questions Questions = Program.QuestionsList.FirstOrDefault(q => q.Question == question.Text);
            if(Questions != null)
            {
                // Question already exists!

            } else
            {
                // Create Question
                Program.QuestionsList.Add(newQuestion);
                Program.db.Add(newQuestion);
                Program.db.SaveChanges();
                MessageBox.Show($"Quiz created!", "Created",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }     
    }
}
