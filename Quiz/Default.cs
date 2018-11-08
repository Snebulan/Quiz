using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "hej")
            {
                Quizscreen QZ = new Quizscreen();
                QZ.Tag = this;
                QZ.StartPosition = FormStartPosition.Manual;
                QZ.Location = this.Location;
                QZ.Show(this);
                Hide();
            }
        }
    }
}