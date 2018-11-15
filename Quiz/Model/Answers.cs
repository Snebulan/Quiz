namespace Quiz.Model
{
    public class Answers
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool CorrectAnswer { get; set; }
        public Questions Questions { get; set; }
    }
}
