using System.Xml.Linq;

namespace Poo_Heritage_Core;

public class Trapeze : Triangle
{
    private double _d;

    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        Name = name;
        A = a;
        B = b;
        C = c;
        D = d;
        H = h;
    }

    public override double GetArea() => (B + D) * H / 2;

    public override double GetPerimeter() => A + B + C + D;

    private double ValidateD(double d)
    {
        if (d <= 0)
        {
            throw new Exception($"The side {d} is less than or equal to zero, it is incorrect.");
        }
        return d;
    }
}