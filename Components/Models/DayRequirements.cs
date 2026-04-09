namespace DayRequirements.Models
{
    // Setting up MIN/MAX staff requirements for each day of the week 
    // in the hopes of creating a drop down bar for each day of the week in the future.
    // on the day requirements page
    public class DayRequirements
    {
        public required int Monday { get; set; }

        public required int Tuesday { get; set; }

        public required int Wednesday { get; set; }

        public required int Thursday { get; set; }

        public required int Friday { get; set; }

        public required int Saturday { get; set; }

        public required int Sunday { get; set; }
    }


// Below will be used to set start time requirements for each day of the week.
    public class StartTimeRequirements
    {
        public List<TimeOnly> StartTimes { get; set; } = new();
    }

    public class EndTimeRequirements
    {
        public List<TimeOnly> EndTimes { get; set; } = new();
    }
}