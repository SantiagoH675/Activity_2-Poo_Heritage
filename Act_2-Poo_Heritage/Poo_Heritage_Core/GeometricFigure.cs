namespace Poo_Heritage_Core;

public abstract class GeometricFigure
{

    public string Name { get; set; } = null!;

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name} => Area: {GetArea()}" + $"Perimeter: {GetPerimeter()}";

    }

}
