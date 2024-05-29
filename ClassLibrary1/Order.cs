namespace ClassLibrary1
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }

        public event EventHandler OrderChanged;

        protected virtual void OnOrderChanged()
        {
            OrderChanged?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateOrder(string customerName, string description)
        {
            CustomerName = customerName;
            Description = description;
            OnOrderChanged();
        }

    }
}