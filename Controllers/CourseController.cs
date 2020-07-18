using System.Linq;
using appCourse.Models;
using Microsoft.AspNetCore.Mvc;

namespace appCourse.Controllers
{
    public class CourseController : Controller
    {
        //action method
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Apply()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if(ModelState.IsValid){
                Repository.AddStudent(student);
                return View("Thanks",student);
            }
            else{
                return View(student);
            }

        }
        public IActionResult List()
        {
            var students = Repository.Students.Where( k=>k.Confirm == true).ToList();
            return View(students);
        }

        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.Description = "Burası açıklama kısmıdır.";
            return View(course);
        }
    }
}