
namespace ShapesCalculator
{
    public class Square : Rectangle
    {
        public double Side { get; }

        public Square(double side) : base("Square", side, side)
        {
            Side = side;
        }

        public override string Describe()
        {
            return $"Square (side={Side}): area = {Area():F2}, perimeter = {Perimeter():F2}";
        }
    }
}