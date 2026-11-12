namespace ShapesCalculator
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height) : this("Rectangle", width, height)
        {

        }
        protected Rectangle(string name, double width, double height) : base(name)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Width and height must be greater than zero.");
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;

        public override double Perimeter() => 2 * (Width + Height);

        public override string Describe()
        {
            return $"{Name} ({Width} x {Height}): area = {Area():F2}, perimeter = {Perimeter():F2}";
        }
    }
}
