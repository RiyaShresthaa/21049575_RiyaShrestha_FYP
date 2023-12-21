using Flora.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flora.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
