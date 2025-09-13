namespace Poo_Heritage_Core;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        Name = name;
        A = a;
        B = b;
        C = c;
        H = h;
    }

    public override double GetArea() => (B * H) / 2;

    public override double GetPerimeter() => A + B + C;

    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new Exception($"The side {c} is less than or equal to zero, it is incorrect.");
        }
        return c;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new Exception($"The Height {h} must be greater than zero, it is incorrect.");
        }
        return h;
    }
}