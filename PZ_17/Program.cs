namespace PZ_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Card card1 = new Card("1234567890123456", "Иванов Иван Иванович", new DateTime(2023, 12, 31), 123, "Дебетовая");
                Card card2 = new Card("9876543210987654", "Петров Петр Петрович", "Кредитная");
                Card card3 = new Card("1111222233334444", "Сидоров Сидор Сидорович", DateTime.Now.AddYears(2), 999, "Дебетовая");
                Card card4 = new Card("5555666677778888", "Алексеев Алексей Алексеевич", "Кредитная");

                card1.PrintInfo();
                Console.WriteLine();
                card2.PrintInfo();
                Console.WriteLine();
                card3.PrintInfo();
                Console.WriteLine();
                card4.PrintInfo();
            }
        }
    }
}