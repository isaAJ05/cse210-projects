public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");

    }
    public Fraction(int _top)
    {
        _bottom = 1;
    }
    public Fraction(int _top, int _bottom)
    {

    }

}
