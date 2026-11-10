using Microsoft.AspNetCore.Mvc;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class DepartmentController : Controller
    {
        public DepartmentLogic Department = new DepartmentLogic();
        public IActionResult Index()
        {
            var departments = Department.GetAllDepartments();
            return View(departments);
        }
    }
}
