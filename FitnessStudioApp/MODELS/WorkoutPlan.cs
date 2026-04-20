using System;
using System.Collections.Generic;
using System;

namespace FitnessStudioApp.MODELS
{
    public enum PlanDifficulty
    {
        Beginner,
        Intermediate,
        Advanced
    }

    public class WorkoutPlan
    {
        public int WorkoutPlanId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public PlanDifficulty Difficulty { get; set; }

        // Owner
        public int OwnerId { get; set; }
        public Client? Owner { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        // Exercises in this plan
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}