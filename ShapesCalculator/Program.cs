namespace ShapesCalculator
{
    internal class Program
    {
        private static readonly List<Shape> shapes = new List<Shape>();
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                ShowMenu();
                string? choice = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    switch (choice)
                    {
                        case "1": shapes.Add(new Circle(ReadDouble("Radius: "))); break;
                        case "2": shapes.Add(new Rectangle(ReadDouble("Width: "), ReadDouble("Height: "))); break;
                        case "3": shapes.Add(new Triangle(ReadDouble("Side A: "), ReadDouble("Side B: "), ReadDouble("Side C: "))); break;
                        case "4": shapes.Add(new Square(ReadDouble("Side: "))); break;
                        case "5": ShowReport(); break;
                        case "6": LoadSamples(); break;
                        case "0": running = false; break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }

                    if (choice is "1" or "2" or "3" or "4")
                        Console.WriteLine($"Added: {shapes[^1]}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            Console.WriteLine("Goodbye!");
        }

        static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=== Shapes calculator ===");
            Console.WriteLine("1. Add circle    4. Add Square");
            Console.WriteLine("2. Add rectangle 5. Report");
            Console.WriteLine("3. Add triangle  6. Load a sample");
            Console.WriteLine("0. Exit");
            Console.Write("Choose: ");
        }

        static void LoadSamples()
        {
            shapes.Add(new Circle(5));
            shapes.Add(new Rectangle(4, 6));
            shapes.Add(new Triangle(3, 4, 5));
            shapes.Add(new Square(3));
            Console.WriteLine("4 sample shapes added.");
        }

        static void ShowReport()
        {
            if (shapes.Count == 0)
            {
                Console.WriteLine("No shapes yet.");
                return;
            }

            double totalArea = 0;
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Describe());
                totalArea += shape.Area();
            }

            Shape largest = shapes.OrderByDescending(s => s.Area()).First();
            Console.WriteLine();
            Console.WriteLine($"Shapes: {shapes.Count}");
            Console.WriteLine($"Total area: {totalArea:F2}");
            Console.WriteLine($"Largest: {largest.Name} ({largest.Area():F2})");
        }

        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;
                Console.WriteLine("Please enter a number.");
            }
        }

    }
}


