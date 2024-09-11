using OOP_Inheritance.Exercise_2.Base;

namespace OOP_Inheritance.Exercise_2.Class
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaration
            double[] height = new double[2];
            double[] width = new double[2];
            double radius;
            string[] figures = { "Rectangle", "Triangle", "Circle" };


            //Input

            Console.WriteLine("Welcome to the Surface Calculator");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Insert the height of the {figures[i]}:");
                height[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"Insert the width of the {figures[i]}:");
                width[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Ingrese el radio del {figures[2]}");
            radius = double.Parse(Console.ReadLine());


            //Operations
            Shape[] shapes =
            [
                new Rectangle(height[0],width[0]),
                new Triangle(height[1],width[1]),
                new Circle(radius)
            ];

            double[] areas = new double[shapes.Length];

            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
            }

            //Result
            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Area del {figures[i]}: {areas[i]:F2}");
            }
        }
    }
}