using DC.GymLog.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DC.GymLog.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Activity> Activity { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Activity>()
                .HasKey(a => a.Id);
            builder.Entity<Activity>()
                .HasOne(x => x.Author)
                .WithMany(x => x.AuthoredActivities)
                .HasForeignKey(x => x.AuthorId);
            builder.Entity<Activity>()
                .HasOne(x => x.Leader)
                .WithMany(x => x.LeadActivities)
                .HasForeignKey(x => x.LeaderId);
            builder.Entity<Participation>()
                .HasKey(x => new { x.ActivityId, x.ParticipantId });
            builder.Entity<Participation>()
                .HasOne(x => x.Activity)
                .WithMany()
                .HasForeignKey(x => x.ActivityId);
            builder.Entity<Participation>()
                .HasOne(x => x.Participant)
                .WithMany()
                .HasForeignKey(x => x.ParticipantId);

        }
    }
}
