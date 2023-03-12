using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult GetTodo()
        {
            return View();
        }
    }
}
