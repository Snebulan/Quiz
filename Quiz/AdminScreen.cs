using Quiz.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            string salt = Program.CreateSalt();
            string password = Program.CreatePassword(Pass, salt);
            // Add user to db
            User newUser = new User
            {
                Name = name_text.Text,
                Email = email_text.Text,
                Role = role,
                Password = password,
                Salt = salt,
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
                PopulateComboBoxes();
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
            PopulateComboBoxes();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
        }

        // Populates the comboboxes with Users & Quizes
        private void PopulateComboBoxes()
        {
            ClearAllComboBoxes();
            foreach (var item in Program.QuizList)
            {
                quiz.Items.Add(item.Name);
                quizList.Items.Add(item.Name);
            }
            foreach (var item in Program.UserList)
            {
                userEmail.Items.Add(item.Email);
            }
        }

        // Clear up Listboxes
        private void ClearAllComboBoxes()
        {
            quiz.Items.Clear();
            userEmail.Items.Clear();
            quizList.Items.Clear();
            questionsList.Items.Clear();
        }

        // Generate a new password for user
        private void editUser_Click(object sender, EventArgs e)
        {
            User userToEdit = Program.UserList.FirstOrDefault(u => u.Email == userEmail.Text);
            if (userToEdit != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to generate a new password for this user?",
                                "Confirm Edit", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string Pass = GeneratePassword(5);
                    string salt = Program.CreateSalt();
                    string password = Program.CreatePassword(Pass, salt);
                    userToEdit.Password = password;
                    Program.db.Update(userToEdit);
                    Program.db.SaveChanges();
                    MessageBox.Show($"Password changed!\nUsername {userEmail.Text}\nPassword: {Pass}", "Password Changed",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Account with this email cannot be found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete a user
        private void deleteUser_Click(object sender, EventArgs e)
        {
            User user = Program.db.Users.FirstOrDefault(u => u.Email == userEmail.Text);
            if (user != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Program.UserList.Remove(user);
                    Program.db.Remove(user);
                    Program.db.SaveChanges();
                    MessageBox.Show($"User deleted!\nUsername {userEmail.Text}", "User deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PopulateComboBoxes();
                }
            }
            else
            {
                MessageBox.Show("Account with this email cannot be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Select quiz and show questions within
        private void quizList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshQuestionsList();
        }

        // Update Questions list combobox
        public void RefreshQuestionsList()
        {
            questionsList.Items.Clear();
            string selected = quizList.SelectedItem.ToString();
            List<Questions> questions = Program.QuestionsList.Where(q => q.Quiz.Name == selected).ToList();
            foreach (var item in questions)
            {
                questionsList.Items.Add(item.Question);
            }
        }

        // Show Dialog
        public string ShowMyDialogBox(string Prompt, string EditedValue, string Title = "Edit Dialog")
        {
            Dialog testDialog = new Dialog();
            testDialog.Text = Title;
            testDialog.Prompt.Text = Prompt + EditedValue;
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                EditedValue = testDialog.TextBox1.Text;
            }
            testDialog.Dispose();
            return EditedValue;
        }

        // Show prompt to edit Quiz name
        private void editQuiz_Click(object sender, EventArgs e)
        {
            if (quizList.SelectedItem != null)
            {
                var NewName = ShowMyDialogBox($"Change name on ", quizList.SelectedItem.ToString(), "Edit quiz name");
                Program.QuizList.FirstOrDefault(q => q.Name == quizList.SelectedItem.ToString()).Name = NewName;
                Program.db.Quiz.FirstOrDefault(q => q.Name == quizList.SelectedItem.ToString()).Name = NewName;
                Program.db.SaveChanges();
                PopulateComboBoxes();
            }
        }

        // Show prompt to edit Question name
        private void editQuestion_Click(object sender, EventArgs e)
        {
            if (questionsList.SelectedItem != null)
            {
                var NewName = ShowMyDialogBox($"Change name on ", questionsList.SelectedItem.ToString(), "Edit question name");
                Program.QuestionsList.FirstOrDefault(q => q.Question == questionsList.SelectedItem.ToString()).Question = NewName;
                Program.db.Questions.FirstOrDefault(q => q.Question == questionsList.SelectedItem.ToString()).Question = NewName;
                Program.db.SaveChanges();
                RefreshQuestionsList();
            }
        }

        // Delete Quiz
        private void deleteQuiz_Click(object sender, EventArgs e)
        {
            List<Answers> answers = Program.AnswersList.Where(a => a.Questions.Quiz.Name == quizList.SelectedItem.ToString()).ToList();
            List<Questions> questions = Program.QuestionsList.Where(q => q.Quiz.Name == quizList.SelectedItem.ToString()).ToList();
            var quiz = Program.QuizList.FirstOrDefault(q => q.Name == quizList.SelectedItem.ToString());
            foreach (var answer in answers)
            {
                Program.AnswersList.Remove(answer);
            }
            foreach (var question in questions)
            {
                Program.QuestionsList.Remove(question);
            }
            Program.QuizList.Remove(quiz);
            Program.db.RemoveRange(answers);
            Program.db.RemoveRange(questions);
            Program.db.Remove(quiz);
            Program.db.SaveChanges();
            MessageBox.Show("Deleted Quiz!", "Deleted",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Iterative removal of data
        private void Deleter(bool DeleteQuiz = false, bool DeleteQuestion = false, bool DeleteAnswers = false)
        {

        }

        // Select question and show answers within
    }
}
