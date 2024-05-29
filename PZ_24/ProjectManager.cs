using System;

namespace PZ_24
{
    internal class ProjectManager
    {
        public Action<object, EventArgs> ProjectsChanged { get; internal set; }

        internal void AddProject(object project)
        {
            throw new NotImplementedException();
        }
    }
}