public class Running : Activity
{
    private double _distance;

    public Running(string nameDateTime date, int minutes, double distance) : base(date, minutes, name)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60; 
    }

    public override double GetPace()
    {
        return _minutes / _distance; 
    }
}