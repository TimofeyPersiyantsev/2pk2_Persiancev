using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PZ_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
        public partial class MainWindow : Window
        {
            private List<Card> cards;

            public MainWindow()
            {
                InitializeComponent();
                InitializeCards();
            }

            private void InitializeCards()
            {
                cards = new List<Card>
            {
                new Card(),
                new Card("1234 5678 9123 4567", "Иванов Иван Иванович", new DateTime(2025, 12, 31), 123, "Кредитная"),
                new Card("9876 5432 1098 7654", "Петров Петр Петрович"),
                new Card("5555 4444 3333 2222", "Сидоров Сидор Сидорович", new DateTime(2026, 11, 30), 321, "Дебетовая")
            };

                foreach (var card in cards)
                {
                    CardListBox.Items.Add(card.Number);
                }
            }

            private void ShowCardInfo_Click(object sender, RoutedEventArgs e)
            {
                if (CardListBox.SelectedIndex != -1)
                {
                    var selectedCard = cards[CardListBox.SelectedIndex];
                    CardInfoTextBlock.Text = $"Номер карты: {selectedCard.Number}\n" +
                                              $"ФИО клиента: {selectedCard.ClientFIO}\n" +
                                              $"Срок действия: {selectedCard.Validity:MM/yy}\n" +
                                              $"Код безопасности: {selectedCard.SecureCode}\n" +
                                              $"Тип карты: {selectedCard.Type}";
                }
                else
                {
                    CardInfoTextBlock.Text = "Выберите карту из списка.";
                }
            }
        }
}
