﻿using System;
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
    public partial class QuizScreen : Form
    {
        public QuizScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: check each radiobutton if answer is correct from db.
            if (radioButton1.Checked)
            {
                MessageBox.Show("fråga1");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("fråga2");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("fråga3");
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("fråga4");
            }
            else
            {
                MessageBox.Show("inget val");
            }
        }

        private void Quizscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
