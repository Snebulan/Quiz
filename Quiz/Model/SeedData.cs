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
                Name = "Admin",
                Email = "admin@admin.com",
                Password = "9D05D7F28A7BE224DF6573E9605EB9DF", // Lösenord
                Salt = "2451988",
                Role = 9,
            },
            new User
            {
                Id = 2,
                Name = "Elev",
                Email = "elev@elev.com",
                Password = "DA93CD05B951D8FBA7AA90950339E2C6", // Lösenord
                Salt = "8897169",
                Role = 1,
            }
        };

        // Add Quizes
        public static Quiz[] Quizes =
        {
            new Quiz
            {
                Id = 1,
                Name = "IT-Säkerhet"
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
            },
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
                Answer = "POD",
                CorrectAnswer = false,
            },



            // Answer number 2
            new Answers
            {
                Id = 5,
                Answer = "Answer 1",
                CorrectAnswer = false,
            },

            new Answers
            {
                Id = 6,
                Answer = "Answer 2",
                CorrectAnswer = true,
            },
            new Answers
            {
                Id = 7,
                Answer = "Answer 3",
                CorrectAnswer = false,
            },
            new Answers
            {
                Id = 8,
                Answer = "Answer 4",
                CorrectAnswer = false,
            },

        };
    }
}
