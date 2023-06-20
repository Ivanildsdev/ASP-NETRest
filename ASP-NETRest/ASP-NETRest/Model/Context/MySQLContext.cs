using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ASP_NETRest.Model.Context
{
    public class MySQLContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }


    }
}
