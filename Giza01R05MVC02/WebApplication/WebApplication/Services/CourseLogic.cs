using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class CourseLogic
    {
        TestOneDBContext context = new TestOneDBContext();
        public List<Course> GetAllCourses()
        {
            return context.Courses.ToList();
        }
    }
}
