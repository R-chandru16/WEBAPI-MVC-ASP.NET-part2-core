using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CoreWebAPIDemo.Models
{
    public class AppDbContext:DbContext
    {


        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Account> accounts { get; set; }

    }
}
