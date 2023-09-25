namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип аккаунта"); 
            string a = Console.ReadLine();
            switch (a)
            {
                case "Временный":
                    Console.WriteLine("Введите логин и пароль");
                    break;
                case "Стандартный":
                    Console.WriteLine("Введите логин пароль, пароль и привязанную почту");
                    break;
                case  "Золотой":
                    Console.WriteLine("Введите логин, пароль, почту и номер банковской карты");
                    break;
                default:
                    Console.WriteLine("Некоректоно введенные данные");
                    break;
            }
        }
    }
}