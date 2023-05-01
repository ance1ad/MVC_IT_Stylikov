using WebApplication1.Models;

namespace WebApplication1.Utils
{
    // как я понял тут будут хранится данные о пользователе
    public class UserHelper
    {
        public static IEnumerable<UserModel> GetUsers() =>
            new List<UserModel>()
            {
                new UserModel()
                {   Login = "Viktor123",
                    Password= "pw12",
                    Name = "Viktor",
                    Age = 23
                },
                new UserModel()
                {   Login = "Viktor123",
                    Password= "pw12",
                    Name = "Alex",
                    Age = 21
                },
            };

    }
}
