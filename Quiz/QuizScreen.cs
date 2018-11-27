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

        // Button to go to next question.
        private void button1_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex != tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
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
        Label lblQuestion, lblAnswer;
        Button btn;
        PictureBox pictureMarker;
        int locationX;
        RadioButton rBtn1;

        public void popluate()
        {
            // Count the question to loop throught.
            int questions = Program.QuestionsList.Count;

            // Set the question count to label.
            lblQuestionsCount.Text = "Antal frågor: " + questions.ToString();

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

                // Add a marker for a questions.
                pictureMarker = new PictureBox();
                pictureMarker.Name = btn.Text;
                pictureMarker.Size = new Size(35, 35);
                pictureMarker.BackgroundImage = Properties.Resources.flag;
                pictureMarker.BackgroundImageLayout = ImageLayout.Center;
                pictureMarker.Location = new Point(0, 15);
                tabControl1.TabPages[i].Controls.Add(pictureMarker);

                // Button click event
                pictureMarker.Click += BtnMarker_Click;
                btn.Click += Btn_Click;


                locationX = 60;
                List<Answers> IdOfQuestion = Program.AnswersList.FindAll(q => q.Questions.Id == i + 1);
                foreach (var answer in IdOfQuestion)
                {
                    // label for every answer in a question.
                    lblAnswer = new Label();
                    lblAnswer.Text = answer.Answer;
                    lblAnswer.Location = new Point(40, locationX += 20);
                    lblAnswer.AutoSize = true;
                    tabControl1.TabPages[i].Controls.Add(lblAnswer);

                    // radiobutton for every answer in a question.
                    rBtn1 = new RadioButton();
                    rBtn1.Location = new Point(20, (locationX += 20) - 25);
                    tabControl1.TabPages[i].Controls.Add(rBtn1);
                }

            }
        }

        // marker button click event for marking the question.
        private void BtnMarker_Click(object sender, EventArgs e)
        {
            PictureBox btnMark = (PictureBox)sender;
            foreach (Control btn in flowLayoutPanel1.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    if (btnMark.Name == btn.Text)
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

        // Button click event for navigating through the questions.
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tabControl1.SelectedIndex = int.Parse(btn.Text) - 1;
        }

        // Button for back to previous question
        private void btnBack_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
            }
        }

        // Get the question number and set it to label.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = (tabControl1.SelectedIndex + 1).ToString();
        }
    }
}
