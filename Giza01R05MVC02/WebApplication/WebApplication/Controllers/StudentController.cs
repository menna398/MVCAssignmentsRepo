using Microsoft.AspNetCore.Mvc;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class StudentController : Controller
    {
        StudentLogic studentLogic = new StudentLogic();
        public IActionResult Index()
        {
            var students = studentLogic.GetAllStudents();
            return View(students);
        }

        public IActionResult Details(int id)
        {
            var student = studentLogic.GetStudentById(id);
            return View(student);
        }

    }
}
