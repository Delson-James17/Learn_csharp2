using Microsoft.AspNetCore.Mvc;
using TodoApp.Repository;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {

        //inmemory
        //database
        //rdbms
        //nosql
        //files

        InMemoryRepository _repo = new InMemoryRepository();
        public IActionResult GetAllTodos()
        {
            var todolist = _repo.GetAllTodos();
            return View(todolist);
        }
    }
}