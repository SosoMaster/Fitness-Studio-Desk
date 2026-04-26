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

                u.Property(u => u.Password).IsRequired();
                u.Property(u=> u.Email).IsRequired().HasMaxLength(50);
                u.Property(u => u.Phone).IsRequired().HasMaxLength(20);


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

                
                t.HasMany(t => t.TrainingSessions)
                 .WithOne(ts => ts.Trainer)
                 .HasForeignKey(ts => ts.TrainerId);
                 


                // Client => Trainer
                t.HasMany(t => t.Clients)
                 .WithOne(c => c.Trainer)
                 .HasForeignKey(c => c.TrainerId);

                t.Property(t => t.TrainerId).IsRequired();
                t.Property(t => t.UserId).IsRequired(false);

                // още ограничения
             t.Property(t => t.Specialty) .IsRequired();
                t.Property(t => t.UserId).IsRequired(false);
                t.Property(t => t.UserId).IsRequired(false);
                t.Property(t => t.TrainingSessions).IsRequired(false);
                
            });

            modelBuilder.Entity<Client>(c =>
            {
                c.HasKey(c=> c.ClientId);
                c.Property(c => c.ClientId).IsRequired();
                c.Property(c => c.UserId).IsRequired(false);

                c.Property(c => c.MembershipStatus).IsRequired();
                // още ограничения

            });


            modelBuilder.Entity<TrainingSession>(ts =>
            {   
                ts.HasKey(ts => ts.TrainingSessionId);
                ts.Property(ts => ts.TrainingSessionId).IsRequired();
                ts.Property(ts => ts.TrainerId).IsRequired();
                ts.HasMany(ts => ts.Bookings)
                 .WithOne(b => b.TrainingSession)
                 .HasForeignKey(b => b.TrainingSessionId);





                // още ограничения
                ts.Property(ts => ts.StartTime).IsRequired();
                ts.Property(ts => ts.EndTime).IsRequired();
                ts.Property(ts => ts.Capacity).IsRequired();
                ts.Property(ts => ts.Description).IsRequired(true);
                ts.Property(ts => ts.Bookings).IsRequired(true);
                ts.Property(ts => ts.Trainer).IsRequired(true);

            }); 



            modelBuilder.Entity<Admin>(a =>
            {
                a.HasKey(a => a.AdminId);
                a.Property(a => a.AdminId).IsRequired();
                a.Property(a => a.UserId).IsRequired(false);
            });





        }
    }
}
