using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        

        private int points = 0;
        private ResultScreen RS;
        private TabPage tab;
        private Label lblQuestion, lblAnswer;
        private Button btn;
        private List<RadioButton> ListOfRadioButtons = new List<RadioButton>();
        private int locationX, questions = 60;
        private Button _lastButtonClicked;
        PictureBox pictureMarker;
        private string quizName;
        private int quizId;
        Timer timer;
        Stopwatch sw;
        int questionsCount;

        public QuizScreen()
        {
            InitializeComponent();
        }

        public QuizScreen(string quizName, int quizId)
        {
            InitializeComponent();
            this.quizName = quizName;
            this.quizId = quizId;
        }

        // Button to go to next question.
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (tabControl1.SelectedIndex < tabControl1.TabPages.Count -1)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }

            else
            {
                CalculatePoints();
                CreateResultScreen(points);
            }
        }

        private void Quizscreen_Load(object sender, EventArgs e)
        {
            popluate();

        }

        List<string> questionsList = new List<string>();
        public void popluate()
        {
            foreach(var question in Program.QuestionsList)
            {
                if(question.Quiz.Id == quizId)
                {
                    questionsList.Add(question.Question);
                }
            }
            // Count the question to loop throught.
            questionsCount = Program.QuestionsList.FindAll(q => q.Quiz.Id == quizId).Count();

            // Set the question count to label.
            lblQuestionsCount.Text = "Antal frågor: " + questionsCount.ToString();

            for (int i = 0; i < questionsList.Count(); i++)
            {
                // Add a lable for the question.
                lblQuestion = new Label();
                lblQuestion.Text = questionsList[i];
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
                btn.Click += Btn_Click;

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
               

                
                locationX = 60;
                List<Answers> IdOfQuestion = Program.AnswersList.FindAll(q => q.Questions.Id == i+1);
                foreach (var answer in IdOfQuestion)
                {
                    
                    // label for every answer in a question.
                    lblAnswer = new Label();
                    lblAnswer.Text = answer.Answer;
                    lblAnswer.Location = new Point(40, locationX += 20);
                    lblAnswer.AutoSize = true;
                    tabControl1.TabPages[i].Controls.Add(lblAnswer);

                    // radiobutton for every answer in a question.
                    ListOfRadioButtons.Add(new RadioButton());
                    ListOfRadioButtons[answer.Id - 1].Location = new Point(20, (locationX += 20) - 25);
                    tabControl1.TabPages[i].Controls.Add(ListOfRadioButtons[answer.Id - 1]);
                    if (answer.CorrectAnswer == true)
                    {
                        ListOfRadioButtons[answer.Id - 1].Text = "1";
                    }
                }
            }  
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tabControl1.SelectedTab = tabControl1.TabPages[btn.Text];
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex >= 1)
            {
                tabControl1.SelectedIndex--;
            }
        }

        

        private void CalculatePoints()
        {
           foreach(var btn in ListOfRadioButtons)
            {
                if(btn.Checked && btn.Text == "1")
                {
                    points++;
                }
            }
        }

        private void Time_lbl_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer1_Tick);
            sw = new Stopwatch();
            timer.Start();
            sw.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_lbl.Text = "Running for " + sw.Elapsed.Seconds.ToString() + " seconds";
            Application.DoEvents();
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = (tabControl1.SelectedIndex + 1).ToString();
            if (tabControl1.SelectedIndex == tabControl1.TabPages.Count - 1)
            {
                btnNext.Text = "End";
            }
            else
            {
                btnNext.Text = "Nästa";
            }
        }

        private void CreateResultScreen(int points)
        {
            RS = new ResultScreen(points,questionsCount);
            RS.Tag = this;
            RS.StartPosition = FormStartPosition.Manual;
            RS.Location = this.Location;
            RS.Show(this);
            Hide();
        }
    }
}
