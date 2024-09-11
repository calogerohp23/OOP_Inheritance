using OOP_Inheritance.Exercise_2.Base;

namespace OOP_Inheritance.Exercise_2.Class
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaracion de variables:
            double[] alto = new double[3];
            double[] ancho = new double[3];
            double radio = 0;
            string[] figuras = { "Rectangulo", "Triangulo", "Circulo" };


            //Ingresos de datos

            Console.WriteLine("Bienvenido a la calculadora de Superficies del ITLA");

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Ingrese el alto del {figuras[i]}:");
                alto[i] = double.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el ancho del {figuras[i]}:");
                ancho[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Ingrese el radio del {figuras[2]}");


            //Operaciones
            Shape[] shapes = new Shape[]
            {
                new Rectangle(alto[1],ancho[1]),
                new Triangle(alto[2],ancho[2]),
                new Circle(radio)
            };

            double[] areas = new double[shapes.Length];

            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
            }

            //Resultado
            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Area del {figuras[i]}: {areas[i]:F2}");
            }
        }
    }
}