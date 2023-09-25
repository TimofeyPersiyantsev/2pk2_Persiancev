namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double s;
            double p;
            double q;
            if (y < 0.5)
            {
                s = (x / 1 + y * x) + 2 * y;
            }
            else
            {
                s = Math.Pow(y, 2) + Math.Pow(x, 2) - Math.Cos(x + 1.5);
            }

            if (s <= 0)
            {
                p = (s / Math.Abs(x + 3)) + 12 * s / Math.Abs(Math.Pow(y , 2) + 7);
            }
            else
            {
                p = (x * y + 1.5 * y) / Math.Sin(Math.PI - s);
            }
            q = Math.Cos(p + s) / 2 * Math.Pow(y, 2);

            Console.WriteLine(q);
        }   
    }       
}