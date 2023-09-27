using System;

namespace ЗЯ_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, -2, -1, -2, -3, -3, 4 };
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
               
                if (array[i] < 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        sum += Math.Abs(array[j]);
                    }
                    break;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}