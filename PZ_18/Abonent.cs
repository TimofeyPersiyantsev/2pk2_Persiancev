using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    internal class Abonent
    {
        private string _fio;
        private Tariff _tariff;
        private int _minutes;
        private double _internetGb;

        public static int MaxiCount { get; private set; }
        public static int StandardCount { get; private set; }
        public static int EconomyCount { get; private set; }

        public string Fio
        {
            get { return _fio; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Поле ФИО не может быть пустым. Повторите ввод.");
                }
                else
                {
                    _fio = value;
                }
            }
        }

        public Tariff Tariff
        {
            get { return _tariff; }
            set
            {
                _tariff = value;
                switch (_tariff)
                {
                    case Tariff.Maxi:
                        MaxiCount++;
                        break;
                    case Tariff.Standard:
                        StandardCount++;
                        break;
                    case Tariff.Economy:
                        EconomyCount++;
                        break;
                }
            }
        }

        public int Minutes
        {
            get
            {
                switch (_tariff)
                {
                    case Tariff.Maxi:
                        return 1000;
                    case Tariff.Standard:
                        return 500;
                    case Tariff.Economy:
                        return 300;
                    default:
                        return 0;
                }
            }
        }

        public double InternetGb
        {
            get
            {
                switch (_tariff)
                {
                    case Tariff.Maxi:
                        return 50.0;
                    case Tariff.Standard:
                        return 30.0;
                    case Tariff.Economy:
                        return 10.0;
                    default:
                        return 0;
                }
            }
        }

        public void MakeCall(int duration)
        {
            _minutes -= duration;
            Console.WriteLine($"Абонент {Fio} совершил звонок продолжительностью {duration} мин, остаток минут {_minutes}");
        }

        public void TransferData(double data)
        {
            _internetGb -= data;
            Console.WriteLine($"Абонент {Fio} передал информацию в объеме {data} Мб, остаток тарифа: {_internetGb} Гб");
        }

        public static void PrintCounts()
        {
            Console.WriteLine($"Количество абонентов на тарифе Макси: {MaxiCount}");
            Console.WriteLine($"Количество абонентов на тарифе Стандарт: {StandardCount}");
            Console.WriteLine($"Количество абонентов на тарифе Эконом: {EconomyCount}");
        }
    }

    public enum Tariff
    {
        Maxi,
        Standard,
        Economy
    }
}
