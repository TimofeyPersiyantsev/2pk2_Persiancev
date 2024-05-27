namespace PZ_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abonent abonent = new Abonent();
            abonent.Fio = "Иванов Иван Иванович";
            abonent.Tariff = Tariff.Maxi;

            abonent.MakeCall(50);
            abonent.TransferData(5);

            Abonent.PrintCounts();
        }
    }
}