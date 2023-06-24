using Microsoft.EntityFrameworkCore;
using slnABCCampus.Model;
using static System.Net.Mime.MediaTypeNames;

namespace slnABCCampus.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<tblStudents> TblStudents { get; set; }
        public DbSet<tblCourses> TblCourses { get; set; }
    }

}
