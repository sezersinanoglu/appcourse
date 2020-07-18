using System;
using Microsoft.AspNetCore.Mvc;

namespace appCourse.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index(){
            
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Sezer Ali";
            
            return View();
        }
        public IActionResult About(){
            return View();
        }
    }
}