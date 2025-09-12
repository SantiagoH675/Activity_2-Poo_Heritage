namespace Poo_Heritage_Core;

public class Kite : Rhombus
{
    private double _b;

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        A = a;
        Name = name;
        B = b;
        D1 = d1;
        D2 = d2;
    }

    public override double GetArea() => (D1 * D2) / 2;

    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new Exception($"The radius {b} is less than or equal to zero, it is incorrect");
        }
        return b;
    }
}