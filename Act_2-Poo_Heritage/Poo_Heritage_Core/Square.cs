namespace Poo_Heritage_Core;

public class Square : GeometricFigure
{
    private double _a;

    public double A
    {
        get => _a;
        set => _a = ValidateR(value);
    }

    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    public override double GetArea() => (A * A);

    public override double GetPerimeter() => 4 * A;

    private double ValidateR(double a)
    {
        if (a <= 0)
        {
            throw new Exception($"The radius {a} is less than or equal to zero, it is incorrect.");
        }
        return a;
    }
}