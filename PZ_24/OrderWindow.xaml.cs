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
using System.Windows.Shapes;

namespace PZ_24
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        private OrderManager orderManager;

        public OrderWindow(OrderManager orderManager)
        {
            InitializeComponent();
            this.orderManager = orderManager;
        }

        private void SaveOrder_Click(object sender, RoutedEventArgs e)
        {
            var order = new Order
            {
                CustomerName = CustomerNameTextBox.Text,
                OrderDate = OrderDatePicker.SelectedDate ?? DateTime.Now,
                Description = DescriptionTextBox.Text
            };
            orderManager.AddOrder(order);
            this.Close();
        }
    }
}
    

