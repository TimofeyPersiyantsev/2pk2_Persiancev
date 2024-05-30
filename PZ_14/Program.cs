namespace PZ_14
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "text.txt";

            // Чтение всех строк из файла
            string[] lines = File.ReadAllLines(filePath);

            // Сортировка массива строк по длине строк
            Array.Sort(lines, (x, y) => x.Length.CompareTo(y.Length));

            // Перезапись отсортированных строк в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Файл успешно перезаписан, строки отсортированы по длине.");

        }
    }
}