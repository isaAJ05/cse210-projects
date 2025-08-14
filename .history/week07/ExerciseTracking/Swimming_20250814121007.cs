public class Swimming : Activity
{
    private double _laps;

    public Swimming(DateTime date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * _lapLength) / 1000.0; // convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60; // speed in kph
    }

    public override double GetPace()
    {
        return _minutes / GetDistance(); // pace in min/km
    }
}