using Microsoft.EntityFrameworkCore;

namespace Task_Tracker.Models.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Project> Projects { get; set; }
    }
}
