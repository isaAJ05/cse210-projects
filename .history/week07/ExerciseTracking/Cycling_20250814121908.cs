public class Cycling : Activity
{
    private double _speed;

    public Cycling(string name, DateTime date, int minutes,string name, double speed) : base(date, minutes, name)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_minutes / 60.0); 
    }

    public override double GetSpeed()
    {
        return _speed; 
    }

    public override double GetPace()
    {
        return 60 / _speed; 
    }
}