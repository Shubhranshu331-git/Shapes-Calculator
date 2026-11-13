namespace ShapesCalculator
{
    public abstract class Shape
    {
        public string Name { get; }

        protected Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public virtual string Describe()
        {
            return $"{Name}: area = {Area():F2}, perimeter = {Perimeter():F2}";
        }

        public override string ToString() => Describe();
    }
}


