using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class StudentLogic
    {
        TestOneDBContext context = new TestOneDBContext();

        public List<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }

        public Student? GetStudentById(int id)
        {
            return context.Students.FirstOrDefault(s => s.Id == id);
        }

    }
}
