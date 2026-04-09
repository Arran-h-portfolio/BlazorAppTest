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
    }
}