namespace PZ_12
{
    internal class Program
    {
        static void Main()
        {
            // Пример использования метода CalculateDeposit
            Console.WriteLine("Сумма вклада: 90000, Срок вклада (в месяцах): 12 = " + CalculateDeposit(90000, 12));
            Console.WriteLine("Сумма вклада: 120000, Срок вклада (в месяцах): 6 = " + CalculateDeposit(120000, 6));
        }

        static double CalculateDeposit(double amount, int months)
        {
            double percentPerMonth = amount < 100000 ? 0.05 : 0.08;
            double totalAmount = amount;

            for (int i = 0; i < months; i++)
            {
                totalAmount += totalAmount * percentPerMonth;
            }

            return totalAmount;
        }
    }
}