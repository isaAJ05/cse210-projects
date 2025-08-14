using System;
public class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public virtual double GetDistance()
    {
        return 0.0;
    }
    public virtual double GetSpeed()
    {
        return 0.0;
    }
    public virtual double GetPace()
    {
        return 0.0;
    }
    public string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_minutes}) minutes, Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}