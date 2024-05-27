using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_17
{
    internal class Card
    {
        // Поля класса
        public string number;
        public string clientFIO;
        public DateTime validity;
        public int secureCode;
        public string type;

        // Конструкторы класса
        public Card(string number, string clientFIO, DateTime validity, int secureCode, string type)
        {
            this.number = number;
            this.clientFIO = clientFIO;
            this.validity = validity;
            this.secureCode = secureCode;
            this.type = type;
        }

        public Card(string number, string clientFIO, string type)
        {
            this.number = number;
            this.clientFIO = clientFIO;
            this.validity = DateTime.Now.AddYears(3);
            this.secureCode = 000;
            this.type = type;
        }

        // Метод класса
        public void PrintInfo()
        {
            Console.WriteLine("Номер карты: " + number);
            Console.WriteLine("ФИО клиента: " + clientFIO);
            Console.WriteLine("Срок действия до: " + validity.ToShortDateString());
            Console.WriteLine("Код безопасности: " + secureCode);
            Console.WriteLine("Тип карты: " + type);
        }
    }
}
