using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class ProjectManager
    {
        private List<Project> projects = new List<Project>();

        public event EventHandler ProjectsChanged;

        protected virtual void OnProjectsChanged()
        {
            ProjectsChanged?.Invoke(this, EventArgs.Empty);
        }

        public void AddProject(Project project)
        {
            projects.Add(project);
            OnProjectsChanged();
        }

        public void RemoveProject(Project project)
        {
            projects.Remove(project);
            OnProjectsChanged();
        }

        public IEnumerable<Project> GetProjects()
        {
            return projects;
        }
    }
}
