using Microsoft.EntityFrameworkCore;
using StudentMvc.Models;

namespace StudentMvc
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}