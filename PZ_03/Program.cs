namespace PZ_03
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите тип аккаунта для регистрации:");
            Console.WriteLine("1 - Временный (логин, пароль)");
            Console.WriteLine("2 - Стандартный (логин, пароль, почта)");
            Console.WriteLine("3 - Золотой (логин, пароль, почта, номер банковской карты)");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterTemporaryAccount();
                    break;
                case "2":
                    RegisterStandardAccount();
                    break;
                case "3":
                    RegisterGoldAccount();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }

        static void RegisterTemporaryAccount()
        {
            Console.Write("Введите логин: ");
            string username = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Логин и пароль не могут быть пустыми.");
                return;
            }

            // Сохранение временного аккаунта (например, в базу данных)
            Console.WriteLine("Временный аккаунт зарегистрирован успешно.");
        }

        static void RegisterStandardAccount()
        {
            Console.Write("Введите логин: ");
            string username = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            Console.Write("Введите почту: ");
            string email = Console.ReadLine();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email));
        {
                Console.WriteLine("Логин, пароль и почта не могут быть пустыми.");
                return;
            }

            // Сохранение стандартного аккаунта (например, в базу данных)
            Console.WriteLine("Стандартный аккаунт зарегистрирован успешно.");
        }

        static void RegisterGoldAccount()
        {
            Console.Write("Введите логин: ");
            string username = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            Console.Write("Введите почту: ");
            string email = Console.ReadLine();

            Console.Write("Введите номер банковской карты: ");
            string cardNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(username) & string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cardNumber))
        {
                Console.WriteLine("Логин, пароль, почта и номер банковской карты не могут быть пустыми.");
                return;
            }

            // Сохранение золотого аккаунта (например, в базу данных)
            Console.WriteLine("Золотой аккаунт зарегистрирован успешно.");
        }
    }
}