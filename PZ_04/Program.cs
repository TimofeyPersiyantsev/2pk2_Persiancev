namespace PZ_04
{
    internal class Program
    {
        static void Main()
        {
            // Задача 1: Вывод значений i и j до достижения разницы
            Console.WriteLine("Задача 1: Инкрементирование и декрементирование переменных i и j.");
            int i = 10;
            int j = 50;
            int requiredDifference = 5;

            while (Math.Abs(i - j) > requiredDifference)
            {
                Console.WriteLine($"i: {i}, j: {j}");
                i++;
                j--;
            }
            Console.WriteLine($"Финальные значения - i: {i}, j: {j}");
            Console.WriteLine("----------------------------------------");

            // Задача 2: Вывод целых чисел из диапазона с шагом
            Console.WriteLine("Задача 2: Вывод чисел из диапазона с шагом.");
            int startRange = 10;
            int endRange = 70;
            int step = 5;

            for (int k = startRange; k <= endRange; k += step)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("----------------------------------------");

            // Задача 3: Вывод n-символов в алфавитном порядке, начиная с указанного символа
            Console.WriteLine("Задача 3: Вывод n-символов в алфавитном порядке.");
            char startChar = 'Г';
            int n = 8;

            for (int l = 0; l < n; l++)
            {
                Console.Write((char)(startChar + l));
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            // Задача 4: Вывод n знаков '#' в m строках
            Console.WriteLine("Задача 4: Вывод n знаков '#' в m строках.");
            int nHash = 4;
            int mLines = 9;

            for (int line = 0; line < mLines; line++)
            {
                for (int hash = 0; hash < nHash; hash++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------");

            // Задача 5: Вывод кратных чисел и их количество
            Console.WriteLine("Задача 5: Вывод кратных чисел и их количество.");
            int startRangeMult = -900;
            int endRangeMult = 500;
            int divisor = 4;
            int countMultiples = 0;

            for (int num = startRangeMult; num <= endRangeMult; num++)
            {
                if (num % divisor == 0)
                {
                    Console.Write(num + " ");
                    countMultiples++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Количество кратных чисел: {countMultiples}");
            Console.WriteLine("----------------------------------------");
        }
    }
}