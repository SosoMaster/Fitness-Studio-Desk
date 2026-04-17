using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS
{
    public class FitnessStudioAppDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<User> Users { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=fitnessstudioapp.db");

        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.HasOne(u => u.Client)
                .WithOne(c => c.User)
                .HasForeignKey<Client>(c => c.UserId);

                u.HasOne(u => u.Admin)
                .WithOne(c => c.User)
                .HasForeignKey<Admin>(c => c.UserId);

                u.HasOne(u => u.Trainer)
                .WithOne(c => c.User)
                .HasForeignKey<Trainer>(c => c.UserId);

                

                u.Property(u => u.Username)
                 .IsRequired()
                 .HasMaxLength(50);

                
            }); 

            

        }
    }
}
