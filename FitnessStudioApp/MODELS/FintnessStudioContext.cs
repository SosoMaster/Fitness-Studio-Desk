using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.MODELS;

public class FintnessStudioContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Admin> Admins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(user =>
        {
            user.HasOne(u => u.Trainer)
                .WithOne(t => t.User)
                .HasForeignKey<Trainer>(t => t.UserId);
        });


    }

}
