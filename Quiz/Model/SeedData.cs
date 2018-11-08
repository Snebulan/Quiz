namespace Quiz.Model
{
    public class SeedData
    {
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
        };
    }
}
