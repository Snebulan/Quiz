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
    public partial class ListStuff : Form
    {
        public ListStuff()
        {
            InitializeComponent();
        }

        private void ListStuff_Load(object sender, EventArgs e)
        {
            table.RowCount = 1;
            table.ColumnCount = 4;
            table.Controls.Add(new Label() { Text = "Id" }, 0, 0);
            table.Controls.Add(new Label() { Text = "Answer" }, 1, 0);
            table.Controls.Add(new Label() { Text = "Correct?" }, 2, 0);
            table.Controls.Add(new Label() { Text = "QuestionsID" }, 3, 0);
            foreach (var answer in Program.db.Answers)
            {
                table.RowCount = table.RowCount + 1;
                table.Controls.Add(new Label() { Text = answer.Id.ToString() }, 0, table.RowCount - 1);
                table.Controls.Add(new Label() { Text = answer.Answer.ToString() }, 1, table.RowCount - 1);
                table.Controls.Add(new Label() { Text = answer.CorrectAnswer.ToString() }, 2, table.RowCount - 1);
                table.Controls.Add(new Label() { Text = answer.Questions.Quiz.Name.ToString() }, 4, table.RowCount - 1);
            }

            table2.RowCount = 1;
            table2.ColumnCount = 4;
            table2.Controls.Add(new Label() { Text = "Id" }, 0, 0);
            table2.Controls.Add(new Label() { Text = "Answer" }, 1, 0);
            table2.Controls.Add(new Label() { Text = "Correct?" }, 2, 0);
            table2.Controls.Add(new Label() { Text = "QuestionsID" }, 3, 0);
            foreach (var Quiz in Program.db.Quiz)
            {
                table2.RowCount = table2.RowCount + 1;
                table2.Controls.Add(new Label() { Text = Quiz.Id.ToString() }, 0, table2.RowCount - 1);
                table2.Controls.Add(new Label() { Text = Program.db.Questions.Where(s => s.Quiz.Id == Quiz.Id).Select(f => f.Question).ToString() }, 1, table2.RowCount - 1);
                table2.Controls.Add(new Label() { Text = Program.db.Answers.Where(a => a.Questions.Quiz.Id == Quiz.Id).Select(s => s.Answer).FirstOrDefault().ToString() }, 2, table2.RowCount - 1);
                table2.Controls.Add(new Label() { Text = Quiz.Name.ToString() }, 4, table2.RowCount - 1);
            }
        }
    }
}
