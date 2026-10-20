using Microsoft.AspNetCore.Mvc;

namespace bai2.Controllers
{
    public class HelloController : Controller
    {
        public string Greeting(string name)
        {
            return "Chao mung cac ban den voi mon hoc asp.net core";
        }

        public string Welcome(string name, int id)
        {
            return $"xin chao {id} - {name}, chuc ban hoc tot net.asp";
        }
        public IActionResult Welcome1(int numTimes,String name)
        {
            ViewBag.id = numTimes;
            ViewData["Name"] = name;
            return View();
        }
    }

 
}