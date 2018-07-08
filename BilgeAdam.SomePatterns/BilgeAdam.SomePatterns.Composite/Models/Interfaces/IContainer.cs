using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.SomePatterns.Composite.Models
{
    interface IContainer : IHierarchical
    {
        IReadOnlyCollection<IHierarchical> Children { get; }
        Employee Manager { get; set; }
        IContainer Add(IHierarchical child);
    }
}
