using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private readonly int Year;
    private readonly int Month;

    public Meetup(int month, int year)
    {
        Year = year;
        Month = month;
    }


    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var result = new DateTime(Year, Month, 1).ToFitSchedule(schedule);

        while (result.DayOfWeek != dayOfWeek)
            result = result.AddDays(1);

        return result;
    }
}

public static class DateTimeExtension
{
    public static DateTime ToFitSchedule(this DateTime time, Schedule schedule)
    {
        switch (schedule)
        {
            case Schedule.First:
                return time;
            case Schedule.Second:
                return time = time.AddDays(7);
            case Schedule.Third:
                return time = time.AddDays(14);
            case Schedule.Fourth:
                return time = time.AddDays(21);
            case Schedule.Teenth:
                return time = time.AddDays(12);
            case Schedule.Last:
                return time = time.AddMonths(1).AddDays(-7);
        }
        return new DateTime();
    }
}