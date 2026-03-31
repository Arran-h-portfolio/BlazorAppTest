using System.Runtime.CompilerServices;

namespace StaffInput.Models
{
    public class StaffInput
    {
        public required string FirstName { get; set; }
        
        public required string LastNameInitial { get; set; }

        public required string Position { get; set; }

        public required string WorkingDays { get; set; }

        public required string StartTime { get; set; }

        public required string EndTime { get; set; }
    }
}