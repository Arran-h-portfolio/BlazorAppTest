namespace RotaEntry.Models
{
    public class RotaEntry
    {
        public string? Id { get; set; } //Unique identifier (Guid.ToString())

        public string? EmployeeID { get; set; } //Link to each staff member

        public int DayOfWeek { get; set; } //0 = Monday, 6 = Sunday

        // Shift Times
        public TimeSpan? StartTime { get; set; } //null = not assigned
        public TimeSpan? EndTime { get; set; } //null = not assigned

        // Validation/Tracking
        public bool HasConflict { get; set; } //Constraint violation flag
        public string? ConflictReason { get; set; } // e.g. "5 consecutive days", "overlapping shift with EmployeeID XYZ"
        public bool IsManuallyEdited { get; set; } // Track if user manually changes rota, useful for if you want to know which parts were automatically generated
    }
}