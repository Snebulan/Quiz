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
        Label lblQuestion;
        Button btn, btnMarker;

        public void popluate()
        {
            int questions = Program.QuestionsList.Count;
            
            for (int i = 0; i < questions; i++)
            {
                // Add a lable for the question.
                lblQuestion = new Label();
                lblQuestion.Text = Program.QuestionsList[i].Question;
                lblQuestion.Location = new Point(40, 30);
                lblQuestion.AutoSize = true;
                // Add a new tab for tabControl
                tab = new TabPage();
                tab.Name = (i + 1).ToString();
                tabControl1.TabPages.Add(tab);
                tabControl1.TabPages[i].Controls.Add(lblQuestion);
                // Add a button to navigate to questions in tabControl
                btn = new Button();
                btn.Text = (i + 1).ToString();
                btn.Size = new Size(flowLayoutPanel1.Width - 10, 35);
                btn.BackgroundImageLayout = ImageLayout.None;
                flowLayoutPanel1.Controls.Add(btn);
                // Button click event
                btnMarker = new Button();
                btnMarker.Name = btn.Text;
                btnMarker.Size = new Size(35, 35);
                btnMarker.BackgroundImage = Properties.Resources.flag;
                btnMarker.BackgroundImageLayout = ImageLayout.Center;
                btnMarker.Location = new Point(0, 15);
                tabControl1.TabPages[i].Controls.Add(btnMarker);
                btnMarker.Click += BtnMarker_Click;
                btn.Click += Btn_Click;

            }
        }

        private void BtnMarker_Click(object sender, EventArgs e)
        {
            Button btnMark = (Button)sender;
            foreach(Control btn in flowLayoutPanel1.Controls)
            {
                if( btn.GetType()== typeof(Button))
                {
                    if(btnMark.Name == btn.Text)
                    {
                        if (btn.BackgroundImage == null)
                        {
                            btn.BackgroundImage = Properties.Resources.flag;
                        }
                        else
                        {
                            btn.BackgroundImage = null;
                        }
                       
                    }
                }
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
