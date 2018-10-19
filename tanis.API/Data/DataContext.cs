using Microsoft.EntityFrameworkCore;
using tanis.API.models;

namespace tanis.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base(options){}

        public DbSet <Value> Values {get; set;}

        public DbSet <User> Users {get; set;}
    }
}