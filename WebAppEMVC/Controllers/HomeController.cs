using Microsoft.AspNetCore.Mvc;

namespace WebAppEMVC.Controllers
{
    public class HomeController : Controller
    {
        //method -> end point - action

       // [HttpGet]// http methods get post put delete 
        public ViewResult Home()
        {
            return View();
        }

        public string Privacy()
        {
            return "Privacy Page !!!!!!!";
        }
    }
}
