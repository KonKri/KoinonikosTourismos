using Microsoft.EntityFrameworkCore;

namespace KoinonikosTourismos.Types
{
    public class KoinonikosTourismosDbContext : DbContext
    {
        public KoinonikosTourismosDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RunnerUp>? RunnerUps { get; set; }
        public DbSet<Selected>? Selected { get; set; }
        public DbSet<Rejected>? Rejected { get; set; }
        public DbSet<RejectedMember>? RejectedMembers { get; set; }
    }
}