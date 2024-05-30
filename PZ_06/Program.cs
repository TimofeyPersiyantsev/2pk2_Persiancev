namespace PZ_06
{
    internal class Program
    {
        static void Main()
        {
            // Определяем массив
            int[] array = { 5, 3, -1, 8, 0, -6, 1 };

            // Вызываем метод для вычисления суммы модулей элементов после первого отрицательного элемента
            int sum = CalculateSumAfterFirstNegative(array);

            // Вывод результата
            Console.WriteLine($"Сумма модулей элементов, расположенных после первого отрицательного элемента: {sum}");
        }

        static int CalculateSumAfterFirstNegative(int[] array)
        {
            int sum = 0;
            bool negativeFound = false;

            // Проходим по массиву
            for (int i = 0; i < array.Length; i++)
            {
                if (negativeFound)
                {
                    // Если отрицательный элемент найден, прибавляем модуль текущего элемента к сумме
                    sum += Math.Abs(array[i]);
                }
                else if (array[i] < 0)
                {
                    // Если текущий элемент отрицательный, устанавливаем флаг
                    negativeFound = true;
                }
            }

            return sum;
        }
    }
}