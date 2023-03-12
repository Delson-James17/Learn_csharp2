using Microsoft.AspNetCore.Mvc;

namespace WebAppEMVC.Controllers
{
    public class EmployeeController : Controller
    {
        //Controller Employee
        //action List
        public string List()
        {
            return "Return all the Employees in a list";
        }
    }
}
