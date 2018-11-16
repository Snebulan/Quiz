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
            //if (radioButton1.Checked)
            //{
            //    //User user = db.Users.FirstOrDefault(u => u.Id == id);
            //    //db.Users.Remove(user);
            //    //db.SaveChanges();

            //    //Program.AnswersList.FirstOrDefault(u => u.Id == id);

            //    if (Program.AnswersList[0].CorrectAnswer == true)
            //    {
            //        MessageBox.Show("Correct");
            //    }
            //}
            //else if (radioButton2.Checked)
            //{
            //    if (Program.AnswersList[1].CorrectAnswer == true)
            //    {
            //        MessageBox.Show("Correct");
            //    }
            //}
            //else if (radioButton3.Checked)
            //{
            //    if (Program.AnswersList[2].CorrectAnswer == true)
            //    {
            //        MessageBox.Show("Correct");
            //    }
            //}
            //else if (radioButton4.Checked)
            //{
            //    if (Program.AnswersList[3].CorrectAnswer == true)
            //    {
            //        MessageBox.Show("Correct");
            //    }
            //}
            //else
            //{
            //        MessageBox.Show("Fill a button");

            //}
        }

        private void Quizscreen_Load(object sender, EventArgs e)
        {

            //label1.Text = Program.QuestionsList[0].Question;
            //radioButton1.Text = Program.AnswersList[0].Answer;
            //radioButton2.Text = Program.AnswersList[1].Answer;
            //radioButton3.Text = Program.AnswersList[2].Answer;
            //radioButton4.Text = Program.AnswersList[3].Answer;
            //RadioButton button = new RadioButton();
            //button.Text = Program.AnswersList[0].Answer;
            //tabControl1.TabPages[0].Controls.Add(button);
            //button.Location = new Point(20, 20);
            popluate();

        }

        TabPage tab;
        Label lbl;
        Button btn;

        public void popluate()
        {
            int questions = Program.QuestionsList.Count;
            MessageBox.Show(questions.ToString());
            for (int i = 0; i < questions; i++)
            {
                lbl = new Label();
                lbl.Text = Program.QuestionsList[i].Question;
                lbl.Location = new Point(40, 30);
                lbl.AutoSize = true;
                tab = new TabPage();
                tab.Name = (i + 1).ToString();
                tabControl1.TabPages.Add(tab);
                tabControl1.TabPages[i].Controls.Add(lbl);
                btn = new Button();
                btn.Text = (i + 1).ToString();
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tabControl1.SelectedIndex = int.Parse(btn.Text) - 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = (tabControl1.SelectedIndex + 1).ToString();
        }
    }
}
