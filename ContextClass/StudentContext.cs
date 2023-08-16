using EndPointsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EndPointsAPI.ContextClass
{
    public class StudentContext:DbContext
    {
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=UJJWAL\SQLEXPRESS;Initial Catalog=EndPointAPI;Integrated Security=true;trustServerCertificate=True;");
        }
        public DbSet<Student> Students { get; set; }
    }
}
