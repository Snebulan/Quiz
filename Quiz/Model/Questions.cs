using System.Collections.Generic;

namespace Quiz.Model
{
    public class Questions
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<Answers> Answers { get; set; }
    }
}
