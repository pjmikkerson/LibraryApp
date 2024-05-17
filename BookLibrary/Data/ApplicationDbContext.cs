using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Library.Models.Book>? Books { get; set; }
        public DbSet<Library.Models.Recommendation>? Recommendations { get; set; }
        public DbSet<Library.Models.BookRecommendationViewModel>? BookRecommendations { get; set; }
    }
}
