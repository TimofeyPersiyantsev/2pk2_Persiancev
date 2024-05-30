namespace PZ_08
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();

            // 1. Создание ступенчатого массива
            string[][] jaggedArray = new string[15][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new string[rand.Next(2, 11)];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = GenerateRandomString(rand, rand.Next(5, 11)); // Генерация случайной строки длиной от 5 до 10
                }
            }

            // 2. Вывод сгенерированного массива в консоль
            Console.WriteLine("Сгенерированный ступенчатый массив:");
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" | ", row));
            }

            // 3. Создание одномерного массива и запись в него последних элементов каждой строки
            string[] lastElements = jaggedArray.Select(row => row.Last()).ToArray();
            Console.WriteLine("\nОдномерный массив с последними элементами каждой строки:");
            Console.WriteLine(string.Join(" | ", lastElements));

            // 4. Поиск максимальных элементов в каждой строке и запись их в массив
            string[] maxElements = jaggedArray.Select(row => row.OrderByDescending(s => s).First()).ToArray();
            Console.WriteLine("\nОдномерный массив с максимальными элементами каждой строки:");
            Console.WriteLine(string.Join(" | ", maxElements));

            // 5. Замена первого элемента и максимального в каждой строке
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int maxIndex = Array.IndexOf(jaggedArray[i], maxElements[i]);
                (jaggedArray[i][0], jaggedArray[i][maxIndex]) = (jaggedArray[i][maxIndex], jaggedArray[i][0]);
            }
            Console.WriteLine("\nМассив после замены первого и максимального элементов:");
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" | ", row));
            }

            // 6. Реверс каждой строки ступенчатого массива
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Array.Reverse(jaggedArray[i]);
            }
            Console.WriteLine("\nМассив после реверса каждой строки:");
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" | ", row));
            }

            // 7. Подсчет
            // a. Среднее значение в каждой строке (для чисел) — не актуально, так как тип данных строки
            // b. Общее количество символов в строках каждой строки массива (для строк)
            int[] lengths = jaggedArray.Select(row => row.Sum(s => s.Length)).ToArray();
            Console.WriteLine("\nОбщее количество символов в каждой строке:");
            Console.WriteLine(string.Join(" | ", lengths));

            // c. Наиболее встречающиеся символы в каждой строке ступенчатого массива (для символов)
            char[] mostCommonChars = jaggedArray.Select(row => row.SelectMany(s => s)
                                                                .GroupBy(c => c)
                                                                .OrderByDescending(g => g.Count())
                                                                .First().Key)
                                                .ToArray();
            Console.WriteLine("\nНаиболее встречающиеся символы в каждой строке:");
            Console.WriteLine(string.Join(" | ", mostCommonChars));
        }

        static string GenerateRandomString(Random rand, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }
}