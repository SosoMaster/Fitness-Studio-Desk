using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS
{
    public class FitnessStudioAppDbContext : DbContext
    {
        // ограничители на полетата 
        // релации
        // ??
        // Logger в сървисите 
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<User> Users { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FItnessStudioApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");

        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.HasKey(x => x.UserId);
                u.Property(x => x.UserId).IsRequired();

                // релация за Client
                u.HasOne(u => u.Client)
                .WithOne(c => c.User)
                .HasForeignKey<Client>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

                // релация за Trainer
                u.HasOne(u => u.Trainer)
                 .WithOne(t => t.User)
                 .HasForeignKey<Trainer>(t => t.UserId)
                 .OnDelete(DeleteBehavior.Cascade);

                // релация за Admin
                u.HasOne(u => u.Admin)
                 .WithOne(a => a.User)
                 .HasForeignKey<Admin>(a => a.UserId)
                 .OnDelete(DeleteBehavior.Cascade);

                u.Property(u => u.Username)
                 .IsRequired()
                 .HasMaxLength(50);


                // за релациите
                u.Property(u => u.Trainer).IsRequired(false);
                u.Property(u => u.Client).IsRequired(false);
                u.Property(u => u.Admin).IsRequired(false);
                
            });

            modelBuilder.Entity<Trainer>(t =>
            {
                t.HasKey(t => t.TrainerId);
                t.Property(t => t.TrainerId).IsRequired();
                t.Property(t => t.UserId).IsRequired(false);
                // още ограничения
            });

            modelBuilder.Entity<Client>(c =>
            {
                c.HasKey(c=> c.ClientId);
                // още ограничения

            });



            

        }
    }
}
