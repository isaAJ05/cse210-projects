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
}