using System.Runtime.CompilerServices;

namespace StaffInput.Models
{
    public class StaffInput
    {
        public required string EmployeeID { get; set; } //Unique identifier for each employee, can be used to link to other tables in the future if needed

        public required string  NewStaffName { get; set; }
        
        public required string LastNameInitial { get; set; }

        public required bool IsManager { get; set; }

        public required string WorkingDays { get; set; }

        public required string StartTime { get; set; }

        public required string EndTime { get; set; }

        public required bool IsActive { get; set; }

        public bool IsAvailableThisWeek { get; set; }

        public List<string> JobRoles { get; set; } = new();

        // Daily availability tracking - maps day name to availability status
        public Dictionary<string, bool> DailyAvailability { get; set; } = new()
        {
            { "Monday", false },
            { "Tuesday", false },
            { "Wednesday", false },
            { "Thursday", false },
            { "Friday", false },
            { "Saturday", false },
            { "Sunday", false }
        };
    }

    public class JobSkills
    {
        public List<string> Skills { get; set; } = new();
    }
}