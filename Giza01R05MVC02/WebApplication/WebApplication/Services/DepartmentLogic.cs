using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class DepartmentLogic
    {
        TestOneDBContext context = new TestOneDBContext();

        public List<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }
    }
}
