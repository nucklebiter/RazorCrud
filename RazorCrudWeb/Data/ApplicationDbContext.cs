using Microsoft.EntityFrameworkCore;
using RazorCrudWeb.Model;

namespace RazorCrudWeb.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Guest> Guest { get; set; }


    }
}
