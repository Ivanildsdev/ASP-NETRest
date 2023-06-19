using Microsoft.EntityFrameworkCore;

namespace ASP_NETRest.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
            
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

    }
}
