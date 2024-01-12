using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            //allow us to pass some options to it
        }

        public DbSet<Activity> Activities { get; set; }
        //Activities is the table name of the database
    }
}