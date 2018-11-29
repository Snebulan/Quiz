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
        

        private int points = 0;
        private ResultScreen RS;
        private TabPage tab;
        private Label lblQuestion, lblAnswer;
        private Button btn, btnMarker;
        private List<RadioButton> ListOfRadioButtons = new List<RadioButton>();
        int locationX, questions = 60;

        

        public QuizScreen()
        {
            InitializeComponent();
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

        

        public void popluate()
        {
            questions = Program.QuestionsList.Count;

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Button btnNext = (Button)sender;
            if (tabControl1.SelectedIndex >= 1)
            {
                tabControl1.SelectedIndex--;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            Button btnNext = (Button)sender;
            if (tabControl1.SelectedIndex == tabControl1.TabCount - 2)
            {
                btnNext.Text = "END";
            }
            else if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
            {
                CalculatePoints();
                CreateResultScreen(points);
    }
            tabControl1.SelectedIndex++; 
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

        private void CalculatePoints()
        {
            foreach (var radioButton in ListOfRadioButtons)
            {
                if (radioButton.Checked && radioButton.Text == "1")
                {
                    points++;
                }
            }
        }

        private void CreateResultScreen(int points)
        {
            
            RS = new ResultScreen(points);
            RS.Tag = this;
            RS.StartPosition = FormStartPosition.Manual;
            RS.Location = this.Location;
            RS.Show(this);
            Hide();
        }
    }
}
