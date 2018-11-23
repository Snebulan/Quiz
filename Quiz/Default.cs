using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz.Model;

namespace Quiz
{
    public partial class Default : Form
    {
        private QuizScreen QZ;
        private AdminScreen AS;

        public Default()
        {
            InitializeComponent();   
        }

        //checks if email and password is correct.
        private void button1_Click(object sender, EventArgs e)
        {
            bool login = false;
            User selectedUser = null;

            //check users email and password
            foreach (User user in Program.UserList)
            {
                if (textBox1.Text == user.Email && textBox2.Text == user.Password)
                {
                    login = true;
                    selectedUser = user;
                }
            }

            //if login, screen is chosen.
            if (login == true)
            {
                if (selectedUser.Role == 1)
                {
                    CreateQuizScreen();
                }
                else
                {
                    CreateAdminScreen();
                }
                
            }
        }

        private void Default_Load(object sender, EventArgs e)
        {

        }

        private void CreateQuizScreen()
        {
            QZ = new QuizScreen();
            QZ.Tag = this;
            QZ.StartPosition = FormStartPosition.Manual;
            QZ.Location = this.Location;
            QZ.Show(this);
            Hide();
        }

        private void CreateAdminScreen()
        {
            AS = new AdminScreen();
            AS.Tag = this;
            AS.StartPosition = FormStartPosition.Manual;
            AS.Location = this.Location;
            AS.Show(this);
            Hide();
        }

    }
}