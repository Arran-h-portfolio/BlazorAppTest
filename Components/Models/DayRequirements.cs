namespace DayRequirements.Models
{
    // Setting up MIN/MAX staff requirements for each day of the week 
    // in the hopes of creating a drop down bar for each day of the week in the future.
    // on the day requirements page

    // Below is the class for determining the number of staff required for each day set as ints
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

    public class DaySpecificStartTimes
    {
        public Dictionary<string, TimeOnly> StartTimesByDay { get; set; } = new()
        {
            { "Monday", new TimeOnly(9, 0) },
            { "Tuesday", new TimeOnly(9, 0) },
            { "Wednesday", new TimeOnly(9, 0) },
            { "Thursday", new TimeOnly(9, 0) },
            { "Friday", new TimeOnly(9, 0) },
            { "Saturday", new TimeOnly(10, 0) },
            { "Sunday", new TimeOnly(10, 0) }
        };
    }

    public class CoverageRequirement
    {
        public int RequiredStaff { get; set; }

        public TimeOnly RequiredByTime { get; set; } = new(9, 0);
    }

    public class DaySpecificCoverageRequirements
    {
        public Dictionary<string, CoverageRequirement> CoverageByDay { get; set; } = new()
        {
            { "Monday", new CoverageRequirement { RequiredStaff = 0, RequiredByTime = new TimeOnly(9, 0) } },
            { "Tuesday", new CoverageRequirement { RequiredStaff = 0, RequiredByTime = new TimeOnly(9, 0) } },
            { "Wednesday", new CoverageRequirement { RequiredStaff = 0, RequiredByTime = new TimeOnly(9, 0) } },
            { "Thursday", new CoverageRequirement { RequiredStaff = 0, RequiredByTime = new TimeOnly(9, 0) } },
            { "Friday", new CoverageRequirement { RequiredStaff = 0, RequiredByTime = new TimeOnly(9, 0) } },
            { "Saturday", new CoverageRequirement { RequiredStaff = 0, RequiredByTime = new TimeOnly(10, 0) } },
            { "Sunday", new CoverageRequirement { RequiredStaff = 0, RequiredByTime = new TimeOnly(10, 0) } }
        };
    }

    public class RotaGenerationOptions
    {
        public bool AlwaysScheduleManagerFirst { get; set; }
    }

    public class EndTimeRequirements
    {
        public List<TimeOnly> EndTimes { get; set; } = new();
    }

    public class JobRoleRequirements
    {
        public List<string> JobRoles { get; set; } = new();
    }

    public class DaySpecificJobRoles
    {
        public Dictionary<string, List<string>> JobRolesByDay { get; set; } = new()
        {
            { "Monday", new List<string>() },
            { "Tuesday", new List<string>() },
            { "Wednesday", new List<string>() },
            { "Thursday", new List<string>() },
            { "Friday", new List<string>() },
            { "Saturday", new List<string>() },
            { "Sunday", new List<string>() }
        };
    }
}