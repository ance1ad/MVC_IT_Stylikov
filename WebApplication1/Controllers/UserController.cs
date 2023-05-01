using Microsoft.AspNetCore.Mvc;
using WebApplication1.Utils;

namespace WebApplication1.Controllers
{
    // добавленый контроллер для пользователя
    public class UserController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult List()
        {
            var users = UserHelper.GetUsers();
            return View(users);
        }

    }
}
