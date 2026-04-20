using System;
using System.Collections.Generic;
using System;

namespace FitnessStudioApp.MODELS
{
    public enum ExerciseType
    {
        Strength,
        Cardio,
        Flexibility,
        Balance
    }

    public class Exercise
    {
        public int ExerciseId { get; set; }

        public string Name { get; set; }

        public ExerciseType Type { get; set; }

        public string? PrimaryMuscle { get; set; }

        public int? DefaultSets { get; set; }
        public int? DefaultReps { get; set; }
        public int? DefaultDurationSeconds { get; set; }

        public string? Notes { get; set; }

        // Navigation to WorkoutPlan via a join entity if needed, simple ICollection for now
        public ICollection<WorkoutPlan> WorkoutPlans { get; set; } = new List<WorkoutPlan>();
    }
}