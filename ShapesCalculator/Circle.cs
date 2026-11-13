
namespace ShapesCalculator
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius) : base("Circle")
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero.");
            Radius = radius;
        }

        public override double Area() => Math.PI * Radius * Radius;

        public override double Perimeter() => 2 * Math.PI * Radius;

        public override string Describe()
        {
            return $"Circle (r= {Radius}): area = {Area():F2}, circumference = {Perimeter():F2}";
        }
    }
}
