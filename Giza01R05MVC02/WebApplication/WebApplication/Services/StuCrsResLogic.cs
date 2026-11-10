using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class StuCrsResLogic
    {
        TestOneDBContext context = new TestOneDBContext();
        public List<StuCrsRes> GetAllStuCrsRes()
        {
            return context.StuCrsRes.ToList();
        }
    }
}
