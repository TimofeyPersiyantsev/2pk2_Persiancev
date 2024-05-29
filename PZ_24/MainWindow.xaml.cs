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
namespace PZ_24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OrderManager orderManager;
        private ProjectManager projectManager;

        public MainWindow()
        {
            InitializeComponent();
            orderManager = new OrderManager();
            projectManager = new ProjectManager();

            orderManager.OrdersChanged += OrderManager_OrdersChanged;
            projectManager.ProjectsChanged += ProjectManager_ProjectsChanged;
            LoadData();
        }

        private void LoadData()
        {
            var orders = JsonStorage.LoadOrders();
            foreach (var order in orders)
            {
                orderManager.AddOrder(order);
            }

            var projects = JsonStorage.LoadProjects();
            foreach (var project in projects)
            {
                projectManager.AddProject(project);
            }
        }

        private void SaveData()
        {
            JsonStorage.SaveOrders(orderManager.GetOrders().ToList());
            JsonStorage.SaveProjects(projectManager.GetProjects().ToList());
        }

        private void OrderManager_OrdersChanged(object sender, EventArgs e)
        {
            OrdersListBox.ItemsSource = null;
            OrdersListBox.ItemsSource = orderManager.GetOrders();
        }

        private void ProjectManager_ProjectsChanged(object sender, EventArgs e)
        {
            ProjectsListBox.ItemsSource = null;
            ProjectsListBox.ItemsSource = projectManager.GetProjects();
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            var orderWindow = new OrderWindow(orderManager);
            orderWindow.Show();
        }

        private void AddProject_Click(object sender, RoutedEventArgs e)
        {
            var projectWindow = new ProjectWindow(projectManager);
            projectWindow.Show();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            SaveData();
        }
    }
}
