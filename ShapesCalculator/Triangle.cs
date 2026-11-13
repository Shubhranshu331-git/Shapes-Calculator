using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCalculator
{
    public class Triangle : Shape
    {
        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public Triangle(double a, double b, double c) : base("Triangle")
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Sides must be greater than zero.");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("These sides cannot form a triangle.");

            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double Perimeter() => SideA + SideB + SideC;

        public override double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override string Describe()
        {
            return $"Triangle ({SideA}, {SideB}, {SideC}): area = {Area():F2}, perimeter = {Perimeter():F2}";
        }
    }
}
