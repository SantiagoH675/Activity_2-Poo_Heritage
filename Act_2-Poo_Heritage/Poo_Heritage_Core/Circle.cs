namespace Poo_Heritage_Core;

public class Circle : GeometricFigure
{
    private double _r;

    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    public Circle(string name, double r)
    {
        Name = name;
        R = r;
    }

    public override double GetArea() => Math.PI * Math.Pow(R, 2);

    public override double GetPerimeter() => 2 * Math.PI * R;

    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new Exception($"The radius {r} is less than or equal to zero, it is incorrect.");
        }
        return r;
    }
}