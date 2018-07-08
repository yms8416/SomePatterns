using BilgeAdam.SomePatterns.Composite.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace BilgeAdam.SomePatterns.Composite.Models
{
    class Unit : IContainer
    {
        public Unit()
        {
            children = new HashSet<IHierarchical>(new HierarchyComparer());
        }
        public string Name { get; set; }

        public IReadOnlyCollection<IHierarchical> Children { get { return children.ToList().AsReadOnly(); } }
        public Employee Manager
        {
            get { return manager; }
            set
            {
                manager = value;
                children.Add(manager);
            }
        }

        public IHierarchical Parent { get; set; }

        public IContainer Add(IHierarchical child)
        {
            if (child != null)
            {
                children.Add(child);
                child.Parent = this;
            }
            return this;
        }

        public string GetPath()
        {
            return this.GetHierarchicalPath();
        }

        public override string ToString()
        {
            return Name;
        }


        private HashSet<IHierarchical> children;
        private Employee manager;
    }
}
