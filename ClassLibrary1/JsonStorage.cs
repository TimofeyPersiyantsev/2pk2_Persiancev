using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ClassLibrary1
{
    internal class JsonStorage
    {
        private static string ordersFile = "orders.json";
        private static string projectsFile = "projects.json";

        public static void SaveOrders(List<Order> orders)
        {
            File.WriteAllText(ordersFile, JsonConvert.SerializeObject(orders, Formatting.Indented));
        }

        public static List<Order> LoadOrders()
        {
            if (File.Exists(ordersFile))
            {
                return JsonConvert.DeserializeObject<List<Order>>(File.ReadAllText(ordersFile));
            }
            return new List<Order>();
        }

        public static void SaveProjects(List<Project> projects)
        {
            File.WriteAllText(projectsFile, JsonConvert.SerializeObject(projects, Formatting.Indented));
        }

        public static List<Project> LoadProjects()
        {
            if (File.Exists(projectsFile))
            {
                return JsonConvert.DeserializeObject<List<Project>>(File.ReadAllText(projectsFile));
            }
            return new List<Project>();
        }
    }
}
