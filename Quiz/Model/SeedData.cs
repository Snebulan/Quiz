using System.Collections.Generic;

namespace Quiz.Model
{
    public class SeedData
    {
        // Add Users
        public static User[] Users =
        {
            new User
            {
                Id = 1,
                Email = "admin@admin.com",
                Password = "Lösenord",
                Salt = "Not Implemented",
                Role = 9,
            },
            new User
            {
                Id = 2,
                Email = "elev@elev.com",
                Password = "Lösenord",
                Salt = "inte implementerat",
                Role = 1,
            }
        };

        //public static List<Questions> Questions = new List<Questions>();
        //public static List<Answers> Answers;

        /*
        // Add Questions?
        public static List<Questions> Questions = new List<Questions>()
        {
            new Questions
            {
                Id = 1,
                Question = "Vad kallas det gamla sättet att göra kryptering på?",
            }
        };
        */

        // Add Quizes
        public static Quiz[] Quizes =
        {
            new Quiz
            {
                Id = 1,
                Name = "IT-Säkerhet",
                Description = "Säkerhet inom IT",
            }
        };

        public static Questions[] Questions =
        {
            new Questions
            {
                Id = 1,
                Question = "Vad är det gamla sättet att kryptera?",
            },
            new Questions
            {
                Id = 2,
                Question = "Vad heter du?",
            }
        };

        
    // Add Answers
    public static Answers[] Answers =
    {
        new Answers
        {
            Id = 1,
            Answer = "MD5",
            CorrectAnswer = true,
        },
        new Answers
        {
            Id = 2,
            Answer = "RSA",
            CorrectAnswer = false,
        },
        new Answers
        {
            Id = 3,
            Answer = "POD",
            CorrectAnswer = false,
        },
        new Answers
        {
            Id = 4,
            Answer = "YLD",
            CorrectAnswer = false,
        }
    };

    }
}
