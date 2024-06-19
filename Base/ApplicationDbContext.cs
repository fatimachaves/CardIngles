using CardIngles.Models;
using Microsoft.EntityFrameworkCore;

namespace CardIngles.Base
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Card> cards { get; set; }
    }
}
