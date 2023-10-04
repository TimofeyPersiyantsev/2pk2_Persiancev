namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[4, 4];
            int col = 0;
            Random random = new Random();
            Console.WriteLine("Массив: \n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    nums[i, j] = random.Next(-15, 15);
                    Console.Write(" " + nums[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0;i < 4; i++)
            {
                for (int j = 0;j < 4; j++)
                {
                    if (i> j)
                    {
                        if (nums[i, j] < 0)
                        {
                            col++;
                        }

                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Количество отрицательных элементов под главной диагональю = {col}");
        }
    }
}