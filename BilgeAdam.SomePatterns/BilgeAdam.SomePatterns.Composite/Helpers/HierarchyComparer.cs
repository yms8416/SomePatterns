using BilgeAdam.SomePatterns.Composite.Models;
using System.Collections.Generic;

namespace BilgeAdam.SomePatterns.Composite.Helpers
{
    class HierarchyComparer : IEqualityComparer<IHierarchical>
    {
        public bool Equals(IHierarchical x, IHierarchical y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(IHierarchical obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
