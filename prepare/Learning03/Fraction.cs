public class Fraction
{
    private double _numerator;
    private double _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(double numTop)
    {
        _numerator = numTop;
        _denominator = 1;
    }

    public Fraction(double numTop, double numBottom)
    {
        _numerator = numTop;
        _denominator = numBottom;
    }

    public double GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(double numTop)
    {
        _numerator = numTop;
    }

    public double GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(double numBottom)
    {
        _denominator = numBottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_numerator} / {_denominator}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double number = _numerator / _denominator;
        return number;
    }
}