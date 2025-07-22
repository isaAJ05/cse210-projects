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
    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bo;
    }
    public void SetBottom(int top)
    {
        _top = top;
    }

}
