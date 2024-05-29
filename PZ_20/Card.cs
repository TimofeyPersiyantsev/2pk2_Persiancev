using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PZ_20
{
    public class Card : ICard
    {
        public string Number { get; set; }
        public string ClientFIO { get; set; }
        public DateTime Validity { get; set; }
        public int SecureCode { get; set; }
        public string Type { get; set; }

        // Конструктор по умолчанию
        public Card()
        {
            Number = "0000 0000 0000 0000";
            ClientFIO = "Неизвестно";
            Validity = DateTime.Now.AddYears(1);
            SecureCode = 000;
            Type = "Дебетовая";
        }

        // Конструктор с параметрами
        public Card(string number, string clientFIO, DateTime validity, int secureCode, string type)
        {
            Number = number;
            ClientFIO = clientFIO;
            Validity = validity;
            SecureCode = secureCode;
            Type = type;
        }

        // Конструктор с частичными параметрами
        public Card(string number, string clientFIO)
        {
            Number = number;
            ClientFIO = clientFIO;
            Validity = DateTime.Now.AddYears(1);
            SecureCode = 000;
            Type = "Дебетовая";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Номер карты: {Number}");
            Console.WriteLine($"ФИО клиента: {ClientFIO}");
            Console.WriteLine($"Срок действия: {Validity.ToString("MM/yy")}");
            Console.WriteLine($"Код безопасности: {SecureCode}");
            Console.WriteLine($"Тип карты: {Type}");
        }
    }
}
