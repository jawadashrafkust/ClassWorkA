using System.Data.Entity;

namespace ClassWork2.Models
{
    public class UniDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<ClassWork2.Models.Program> Programs { get; set; }
    }
}