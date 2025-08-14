public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return
    }

    public override double GetSpeed()
    {
        return _speed; 
    }

    public override double GetPace()
    {
        return 60.0 / _speed; 
    }
}