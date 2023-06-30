using Microsoft.EntityFrameworkCore;

namespace Dypa.KoinonikosTourismos.Types
{
    public class DypaDbContext : DbContext
    {
        public DypaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RunnerUp>? RunnerUps { get; set; }
        public DbSet<Selected>? Selected { get; set; }
        public DbSet<Rejected>? Rejected { get; set; }
        public DbSet<RejectedMember>? RejectedMembers { get; set; }
    }
}