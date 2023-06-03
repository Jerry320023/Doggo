using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchroniskoPsy.Models;

namespace SchroniskoPsy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SchroniskoPsy.Models.Psy>? Psy { get; set; }
        public DbSet<SchroniskoPsy.Models.Schronisko>? Schronisko { get; set; }
    }
}