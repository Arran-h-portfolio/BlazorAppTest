namespace DayRequirements.Models
{
    // Setting up MIN/MAX staff requirements for each day of the week 
    // in the hopes of creating a drop down bar for each day of the week in the future.
    // on the day requirements page
    public class DayRequirements
    {
        public required string Monday { get; set; }

        public required string Tuesday { get; set; }

        public required string Wednesday { get; set; }

        public required string Thursday { get; set; }

        public required string Friday { get; set; }

        public required string Saturday { get; set; }

        public required string Sunday { get; set; }
    }
}