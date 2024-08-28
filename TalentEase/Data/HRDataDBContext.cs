using Microsoft.EntityFrameworkCore;
using TalentEase.Api.Models.Domain;
using TalentEase.Api.Models.Dto;

namespace TalenEase.Api.Data
{
    public class HRDataDbContext : DbContext
    {
        public HRDataDbContext(DbContextOptions<HRDataDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20);

                entity.Property(e => e.HireDate)
                    .IsRequired();

                entity.Property(e => e.JobId)
                    .IsRequired();

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ManagerId);

                entity.Property(e => e.DepartmentId);
            });

            modelBuilder.Entity<Dependent>(entity =>
            {
                entity.HasKey(d => d.DependentId);

                entity.Property(d => d.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(d => d.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(d => d.Relationship)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(d => d.EmployeeId)
                    .IsRequired();
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(j => j.JobId);

                entity.Property(j => j.JobTitle)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.Property(j => j.MinSalary)
                    .HasColumnType("decimal(8, 2)");

                entity.Property(j => j.MaxSalary)
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(d => d.DepartmentId);

                entity.Property(d => d.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(d => d.LocationId);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(l => l.LocationId);

                entity.Property(l => l.StreetAddress)
                    .HasMaxLength(40);

                entity.Property(l => l.PostalCode)
                    .HasMaxLength(12);

                entity.Property(l => l.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(l => l.StateProvince)
                    .HasMaxLength(25);

                entity.Property(l => l.CountryId)
                    .IsRequired();
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(c => c.CountryId);

                entity.Property(c => c.CountryName)
                    .HasMaxLength(40);

                entity.Property(c => c.RegionId)
                    .IsRequired();
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(r => r.RegionId);

                entity.Property(r => r.RegionName)
                    .HasMaxLength(25);
            });
        }

    }


}
