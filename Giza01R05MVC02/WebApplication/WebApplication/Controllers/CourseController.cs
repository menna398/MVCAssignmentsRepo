using Microsoft.AspNetCore.Mvc;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class CourseController : Controller
    {
        public CourseLogic course = new CourseLogic();
        public IActionResult Index()
        {
            var courses = course.GetAllCourses();
            return View(courses);
        }

    }
}
