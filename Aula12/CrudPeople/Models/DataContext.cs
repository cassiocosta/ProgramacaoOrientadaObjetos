using Microsoft.EntityFrameworkCore;

namespace CrudPeople.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {            
        }

        public DbSet<Person> people { get; set; }
        public DbSet<City> cities { get; set; }
    }
}