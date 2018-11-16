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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {

        }

        private void student_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void teacher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
