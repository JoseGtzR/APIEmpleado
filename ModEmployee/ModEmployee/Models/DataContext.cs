using System.Data.Entity;

namespace ModEmployee.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ModEmployee.Models.Employee> Employees { get; set; }
    }
}