﻿using System.Collections.Generic;

namespace Quiz.Model
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Questions> Questions { get; set; }
    }
}
