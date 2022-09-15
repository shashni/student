using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Student.Models;

namespace Student.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options):base(options)
        {

        }
        public virtual DbSet<StudentInfo> StudentInfos { get; set; }
    }
}
