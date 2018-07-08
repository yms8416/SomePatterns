using BilgeAdam.SomePatterns.Composite.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.SomePatterns.Composite.Models
{
    class Employee : IHierarchical
    {
        public string Name { get; set; }
        public IHierarchical Parent { get; set; }
        public string GetPath()
        {
            return this.GetHierarchicalPath();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
