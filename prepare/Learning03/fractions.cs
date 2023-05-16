 using System;
 
 
 public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int integer)
    {
        _top = integer;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetNumerador()
    {
        return _top;
    }

    public void SetNumerador(int top)
    {
        _top = top;
    }

    public int GetDenominador()
    {
        return _bottom;
    }

    public void SetDenominador(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFraction()
    {
        return $"{_top}/{_bottom}";
    }

    public double DecimalValue()
    {
        return (double)_top / _bottom;
    }

}