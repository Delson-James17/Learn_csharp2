using Microsoft.AspNetCore.Mvc;

namespace WebAppEMVC.Controllers
{
    public class SampleController : Controller
    {
       public ViewResult About()
        {
            return View();
        }
    }
}
