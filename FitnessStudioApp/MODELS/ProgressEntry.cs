using System;
using System;

namespace FitnessStudioApp.MODELS
{
    public class ProgressEntry
    {
        public int ProgressEntryId { get; set; }

        public int ClientId { get; set; }
        public Client? Client { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public double? WeightKg { get; set; }
        public double? BodyFatPct { get; set; }

        public string? Notes { get; set; }
        public string? PhotoPath { get; set; }
    }
}