using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mis561_assignment3.Models;

namespace mis561_assignment3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<mis561_assignment3.Models.Actor> Actor { get; set; } = default!;
        public DbSet<mis561_assignment3.Models.Movie> Movie { get; set; } = default!;
        public DbSet<mis561_assignment3.Models.MovieActor> MovieActor { get; set; } = default!;
    }
}
