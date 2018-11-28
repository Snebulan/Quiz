using Quiz.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Quiz
{
    public partial class AdminScreen : Form
    {
        // Init
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

        // Add user
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
            if (user != null)
            {
                MessageBox.Show("Email is already in use!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.UserList.Add(newUser);
                Program.db.Add(newUser);
                Program.db.SaveChanges();
                if (role == 1)
                {
                    MessageBox.Show($"Student created!\nUsername {email_text.Text}\nPassword: {Pass}", "Created",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Teacher created!\nUsername {email_text.Text}\nPassword: {Pass}", "Created",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Add Quiz
        private void addQuestion_Click(object sender, EventArgs e)
        {
            Model.Quiz newQuiz = new Model.Quiz { Name = quiz.Text };
            Model.Quiz Quiz = Program.QuizList.FirstOrDefault(q => q.Name == quiz.Text);
            if (Quiz != null)
            {
                // Quiz already exists, use it
                createQuestion(Quiz);
            }
            else
            {
                // Create Quiz
                Program.db.Add(newQuiz);
                Program.db.SaveChanges();
                Program.QuizList.Add(newQuiz);
                createQuestion(newQuiz);
            }
        }

        // Create Question
        private void createQuestion(Model.Quiz quiz)
        {
            Questions newQuestion = new Questions { Question = question.Text, Quiz = quiz };
            Questions Questions = Program.QuestionsList.FirstOrDefault(q => q.Question == question.Text);
            if (Questions != null)
            {
                // Question already exists!
                createAnswer(Questions);
            }
            else
            {
                // Create Question
                Program.db.Add(newQuestion);
                Program.db.SaveChanges();
                Program.QuestionsList.Add(newQuestion);
                createAnswer(newQuestion);
            }
        }

        // Create answer
        private void createAnswer(Questions question)
        {
            var answer = QuestionBox.Controls.OfType<TextBox>().Where(c => c.Name.StartsWith("answer")).ToList();
            var answerTrue = QuestionBox.Controls.OfType<CheckBox>().Where(c => c.Name.StartsWith("checkAnswer")).Select(s => s.Checked).ToList();
            for (int i = 0; i < 4; i++)
            {
                Answers newAnswer = new Answers { Answer = answer[i].Text, CorrectAnswer = answerTrue[i], Questions = question };
                // Create Question
                Program.db.Add(newAnswer);
                Program.AnswersList.Add(newAnswer);
            }
            Program.db.SaveChanges();
            MessageBox.Show($"Quiz Question created!", "Created",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            foreach (var item in Program.QuizList)
            {
                quiz.Items.Add(item.Name);
            }
        }
    }
}
