namespace WebApplication.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }

        public int DepartmentId { get; set; }
    }
}
