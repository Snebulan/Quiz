using Quiz.Model;
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
    public partial class ResultScreen : Form
    {
        public ResultScreen()
        {
            InitializeComponent();
        }

        private int points;
        private int totalPoints;

        public ResultScreen(int points, int totalPoints)
        {
            InitializeComponent();
            this.points = points;
            this.totalPoints = totalPoints;
        }


        private void ResultScreen_Load(object sender, EventArgs e)
        {
            lblResult.Text = $"You goint {points} rights out of {totalPoints}!";
        }
    }
}
