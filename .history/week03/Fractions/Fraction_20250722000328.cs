public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;

    }
    public Fraction(int _top)
    {
        _bottom = 1;
    }
    public Fraction(int _top, int _bottom)
    {
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int _top)
    {
        _top = _top;
    }

}
