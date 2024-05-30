namespace PZ_07
{
    internal class Program
    {
        static void Main()
        {
            // Определяем квадратную матрицу
            int[,] matrix =
            {
            {  5,  3, -1,  4 },
            { -2,  7,  6,  2 },
            {  0, -3,  8, -5 },
            {  1,  4, -6, -7 }
        };

            // Вызываем метод для подсчета количества отрицательных элементов под главной диагональю
            int count = CountNegativeElementsBelowMainDiagonal(matrix);

            // Вывод результата
            Console.WriteLine($"Количество отрицательных элементов под главной диагональю: {count}");
        }

        static int CountNegativeElementsBelowMainDiagonal(int[,] matrix)
        {
            int count = 0;
            int size = matrix.GetLength(0); // Размерность квадратной матрицы

            // Проходим по всем элементам под главной диагональю
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}