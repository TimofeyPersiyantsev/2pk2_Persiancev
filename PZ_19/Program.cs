using System.Drawing;

namespace PZ_19
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("прямоугольник");
                Rectangle rectangle = new Rectangle();
                Console.WriteLine($"Площадь {rectangle.CalculateArea(5, 10)}");
                Console.WriteLine($"Периметр {rectangle.CalculatePerimeter(5, 10)}");

                Console.WriteLine("Треугольник");
                Triangle triangle = new Triangle();
                Console.WriteLine($"Площадь {triangle.CalculateArea(5, 10, 12)}");
                Console.WriteLine($"Периметр {triangle.CalculatePerimeter(5, 10, 12)}");

                Console.WriteLine("окружностm");
                Circle circle = new Circle();
                Console.WriteLine($"Площадь {circle.CalculateArea(5)}");
                Console.WriteLine($"Длина {circle.CalculatePerimeter(5)}");


                double rectangleArea = rectangle.CalculateArea(5, 10);
                double circleArea = circle.CalculateArea(5);
                Console.WriteLine(rectangleArea > circleArea);
            
        }
    }
}