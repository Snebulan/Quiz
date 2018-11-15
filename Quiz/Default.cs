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

        public Default()
        {
            InitializeComponent();
            
        }

        //checks if email and password is correct.
        private void button1_Click(object sender, EventArgs e)
        {
            bool email = false;
            bool password = false;

            if (textBox1.Text == Program.UserList[0].Email)
            {
                //TODO: check if user is admin and choose admin interface instead.
                //TODO: check if user is public and choose quiz interface.
                email = true;
            }

            if (textBox2.Text == Program.UserList[0].Password)
            {
                password = true;
            }

            if (email && password)
            {
                CreateQuizScreen();
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

    }
}