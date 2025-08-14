using System;
public class Activity
{
    private DateTime _date;
    protected int _minutes;
    private string _name;

    public Activity(DateTime date, int minutes, )
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
    public string GetSummary(string name)
    {
        return $"{_date.ToShortDateString()} {name} ({_minutes} min): Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/per km";
    }
}