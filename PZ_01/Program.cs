
using System;

namespace PZ_01 
{
       class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());


            double b = Convert.ToDouble(Console.ReadLine());


            double w = Convert.ToDouble(Console.ReadLine());


            double result;


            double result1;

            double result2;

            double result3;


            result1 = (1 + Math.Abs(b - a)) * (Math.Pow(a,b + 1) + Math.Exp(b-1)) / (1 + (a * Math.Abs(b - Math.Tan(w))));

            result2 = Math.Pow(Math.Abs(b - a), 2) / 2;

            result3 = Math.Pow(Math.Abs(b - a), 3) / 3;

            result = result1 + result2 - result3;

            Console.WriteLine(result);




        }
    }
 }