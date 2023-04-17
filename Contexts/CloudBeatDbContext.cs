using CloudBeatAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudBeatAPI.Contexts
{
    public class CloudBeatDbContext : DbContext
    {
        public CloudBeatDbContext(DbContextOptions<CloudBeatDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<PatientRecord> Patients { get; set; }
        public DbSet<DeviceRecord> Devices { get; set; }
        public DbSet<EventRecord> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientRecord>()
                .HasOne(p => p.Device)
                .WithMany(d => d.Patients)
                .HasForeignKey(p => p.DeviceId);

            modelBuilder.Entity<EventRecord>()
                .HasOne(e => e.Patient)
                .WithMany(p => p.Events)
                .HasForeignKey(e => e.PatientId);
        }
    }
}