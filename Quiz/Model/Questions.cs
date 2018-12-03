using System.Collections.Generic;

namespace Quiz.Model
{
    public class Questions
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public Quiz Quiz { get; set; }
        public int questionId { get; set; } // To get the question id that matches the quiz id
    }
}
