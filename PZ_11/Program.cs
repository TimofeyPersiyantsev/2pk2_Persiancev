namespace PZ_11
{
    internal class Program
    {
        static void RectPS(double x1, double y1, double x2, double y2, out double P, out double S)
        {
            double width = Math.Abs(x2 - x1);
            double height = Math.Abs(y2 - y1);

            P = 2 * (width + height);
            S = width * height;
        }

        static void Main()
        {
            double x1, y1, x2, y2;
            double P, S;

            // Прямоугольник 1
            x1 = 0; y1 = 0;
            x2 = 3; y2 = 4;
            RectPS(x1, y1, x2, y2, out P, out S);
            Console.WriteLine("Периметр прямоугольника 1: " + P);
            Console.WriteLine("Площадь прямоугольника 1: " + S);

            // Прямоугольник 2
            x1 = 1; y1 = 1;
            x2 = 5; y2 = 3;
            RectPS(x1, y1, x2, y2, out P, out S);
            Console.WriteLine("Периметр прямоугольника 2: " + P);
            Console.WriteLine("Площадь прямоугольника 2: " + S);

            // Прямоугольник 3
            x1 = -2; y1 = -3;
            x2 = 0; y2 = 0;
            RectPS(x1, y1, x2, y2, out P, out S);
            Console.WriteLine("Периметр прямоугольника 3: " + P);
            Console.WriteLine("Площадь прямоугольника 3: " + S);
        }
    }
}