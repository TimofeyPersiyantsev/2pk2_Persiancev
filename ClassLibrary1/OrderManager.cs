using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class OrderManager
    {
        private List<Order> orders = new List<Order>();

        public event EventHandler OrdersChanged;

        protected virtual void OnOrdersChanged()
        {
            OrdersChanged?.Invoke(this, EventArgs.Empty);
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
            OnOrdersChanged();
        }

        public void RemoveOrder(Order order)
        {
            orders.Remove(order);
            OnOrdersChanged();
        }

        public IEnumerable<Order> GetOrders()
        {
            return orders;
        }
    }
}
