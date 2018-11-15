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
                if (Program.AnswersList[0].CorrectAnswer == true)
                {
                    MessageBox.Show("Correct");
                }
            }
            else if (radioButton2.Checked)
            {
                if (Program.AnswersList[1].CorrectAnswer == true)
                {
                    MessageBox.Show("Correct");
                }
            }
            else if (radioButton3.Checked)
            {
                if (Program.AnswersList[2].CorrectAnswer == true)
                {
                    MessageBox.Show("Correct");
                }
            }
            else if (radioButton4.Checked)
            {
                if (Program.AnswersList[3].CorrectAnswer == true)
                {
                    MessageBox.Show("Correct");
                }
            }
            else
            {
                    MessageBox.Show("Fill a button");
                
            }
        }

        private void Quizscreen_Load(object sender, EventArgs e)
        {
            label1.Text = Program.QuestionsList[0].Question;
            radioButton1.Text = Program.AnswersList[0].Answer;
            radioButton2.Text = Program.AnswersList[1].Answer;
            radioButton3.Text = Program.AnswersList[2].Answer;
            radioButton4.Text = Program.AnswersList[3].Answer;
        }
    }
}
