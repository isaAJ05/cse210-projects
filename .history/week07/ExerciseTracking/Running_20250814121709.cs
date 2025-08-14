public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, string name, double distance) : base(date, minutes, name)
    {
        _distance = distance;
        _name = "Running"; 
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