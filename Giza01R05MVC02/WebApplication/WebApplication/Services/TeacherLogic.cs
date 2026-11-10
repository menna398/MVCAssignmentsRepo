using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class TeacherLogic
    {
        TestOneDBContext context = new TestOneDBContext();
        public List<Teacher> GetAllTeachers()
        {
            return context.Teachers.ToList();
        }

        public Teacher? GetTeacherById(int id)
        {
            return context.Teachers.FirstOrDefault(t => t.Id == id);
        }
    }
}
