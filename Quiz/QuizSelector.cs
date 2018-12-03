using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Quiz.Model;

namespace Quiz
{
    public partial class QuizSelector : Form
    {
        public QuizSelector()
        {
            InitializeComponent();
        }
        public static Database db = new Database();
        public static List<Model.Quiz> QuizList = db.Quiz.ToList();

        private void QuizSelector_Load(object sender, EventArgs e)
        {
            // Fill the comboBox with quiz list.
            foreach(var quiz in QuizList)
            {
                comboBox1.Items.Add(quiz.Name);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string quizName = comboBox1.Text;
            int quizId = QuizList.Find(q => q.Name == comboBox1.Text).Id;
            QuizScreen quizScreen = new QuizScreen(quizName, quizId); // Pass the quiz id and title
            quizScreen.Show();
            Hide();
        }
    }
}
