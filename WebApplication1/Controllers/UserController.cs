using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    // добавленый контроллер для пользователя
    public class UserController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
    }
}
