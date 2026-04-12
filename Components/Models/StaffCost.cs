namespace StaffCost.Models
{
    public class StaffCost
    {
        public string EmployeeID { get; set; }

        public decimal TotalCost { get; set; }

        public StaffCost(string employeeID, decimal totalCost)
        {
            EmployeeID = employeeID;
            TotalCost = totalCost;
        }
    }

    public class StaffCostWithName : StaffCost
    {
        public string EmployeeName { get; set; }

        public StaffCostWithName(string employeeID, decimal totalCost, string employeeName) : base(employeeID, totalCost)
        {
            EmployeeName = employeeName;
        }
    }

    public class TotalStaffCostPerDay
    {
        public int DayOfWeek { get; set; } //0 = Monday, 6 = Sunday

        public decimal TotalCost { get; set; }

        public TotalStaffCostPerDay(int dayOfWeek, decimal totalCost)
        {
            DayOfWeek = dayOfWeek;
            TotalCost = totalCost;
        }
    }

    public class TotalStaffCostPerWeek
    {
        public decimal TotalCost { get; set; }

        public TotalStaffCostPerWeek(decimal totalCost)
        {
            TotalCost = totalCost;
        }
    }
}
