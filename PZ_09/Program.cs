using System.Text.RegularExpressions;

namespace PZ_09
{
    internal class Program
    {
        static void Main()
        {
            // Ввод строки
            Console.WriteLine("Введите строку, содержащую дату в формате «DD month YYYY»:");
            string input = Console.ReadLine();

            // Регулярное выражение для поиска даты в формате «DD month YYYY»
            string pattern = @"(\d{1,2})\s+([а-яА-Я]+)\s+(\d{4})";

            // Словарь месяцев для преобразования
            var months = new Dictionary<string, string>
        {
            { "января", "01" },
            { "февраля", "02" },
            { "марта", "03" },
            { "апреля", "04" },
            { "мая", "05" },
            { "июня", "06" },
            { "июля", "07" },
            { "августа", "08" },
            { "сентября", "09" },
            { "октября", "10" },
            { "ноября", "11" },
            { "декабря", "12" }
        };

            // Замена даты в строке
            string result = Regex.Replace(input, pattern, match =>
            {
                string day = match.Groups[1].Value.PadLeft(2, '0');
                string month = match.Groups[2].Value.ToLower();
                string year = match.Groups[3].Value;

                if (months.TryGetValue(month, out string monthNumber))
                {
                    return $"{day}.{monthNumber}.{year}";
                }
                return match.Value;
            });

            // Вывод преобразованной строки
            Console.WriteLine("Преобразованная строка:");
            Console.WriteLine(result);
        }
    }
}