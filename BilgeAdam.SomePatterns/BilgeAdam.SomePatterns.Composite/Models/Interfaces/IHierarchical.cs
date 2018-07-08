using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.SomePatterns.Composite.Models
{
    interface IHierarchical
    {
        IHierarchical Parent { get; set; }
        string Name { get; set; }
        string ToString();
        string GetPath();
    }
}
