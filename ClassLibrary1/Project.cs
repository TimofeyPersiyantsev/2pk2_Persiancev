using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public event EventHandler ProjectChanged;

        protected virtual void OnProjectChanged()
        {
            ProjectChanged?.Invoke(this, EventArgs.Empty);
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
            OnProjectChanged();
        }

        public void RemoveOrder(Order order)
        {
            Orders.Remove(order);
            OnProjectChanged();
        }
    }
}
