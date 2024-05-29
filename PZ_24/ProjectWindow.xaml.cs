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
    /// Логика взаимодействия для ProjectWindow.xaml
    /// </summary>
    public partial class ProjectWindow : Window
    { 
        public ProjectWindow(ProjectManager projectManager)
        {
            InitializeComponent();
            this.projectManager = projectManager;
        }

        private void SaveProject_Click(object sender, RoutedEventArgs e)
        {
            var project = new Project
            {
                ProjectName = ProjectNameTextBox.Text
            };
            projectManager.AddProject(project);
            this.Close();
        }
    }
}
