using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace FitnessStudioApp.MODELS
{
    public enum UserRole
    {
        Client,
        Trainer,
        Admin
    }

    public class Client
    {
        public int ClientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public UserRole Role { get; set; } = UserRole.Client;

        public DateTime? DateOfBirth { get; set; }

        public string? Phone { get; set; }

        public string? ProfileImagePath { get; set; }

        // Navigation properties
        public ICollection<Membership> Memberships { get; set; } = new List<Membership>();
        public ICollection<WorkoutPlan> WorkoutPlans { get; set; } = new List<WorkoutPlan>();
        public ICollection<ProgressEntry> ProgressEntries { get; set; } = new List<ProgressEntry>();
    }
}
