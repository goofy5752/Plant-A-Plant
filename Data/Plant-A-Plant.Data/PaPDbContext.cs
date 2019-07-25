namespace Plant_A_Plant.Data
{
    using Microsoft.AspNetCore.Identity;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class PaPDbContext : IdentityDbContext<PaPUser, IdentityRole, string>
    {
        public PaPDbContext(DbContextOptions<PaPDbContext> options)
            : base(options)
        {
        }

        public DbSet<PaPUser> PaPUsers { get; set; }

        public DbSet<RegisterActivity> RegisterActivities { get; set; }

        public DbSet<Field> Fields { get; set; }

        public DbSet<FeedbackInfo> Feedback { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Family> Families { get; set; }

        public DbSet<PestType> PestTypes { get; set; }

        public DbSet<Plant> Plants { get; set; }

        public DbSet<Pest> Pests { get; set; }

        public DbSet<PestsPlants> PestsPlants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Event>()
                .HasOne(e => e.Field)
                .WithOne(f => f.Event)
                .HasForeignKey<Field>(f => f.EventId);
        }
    }
}
