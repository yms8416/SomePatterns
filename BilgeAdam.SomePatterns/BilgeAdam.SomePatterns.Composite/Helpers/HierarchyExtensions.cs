using BilgeAdam.SomePatterns.Composite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.SomePatterns.Composite.Helpers
{
    static class HierarchyExtensions
    {
        public static TreeNode ConvertToNode(this IContainer container)
        {
            var hr = container as IHierarchical;
            if (hr == null)
            {
                return null;
            }
            var main = new TreeNode($"{hr.Name} - ({container.Manager})");
            main.Tag = hr;
            foreach (var child in container.Children)
            {
                TreeNode childNode = null;
                if (child is IContainer)
                {
                    var unit = (child as IContainer);
                    childNode = unit.ConvertToNode();
                    var text = $"{child.Name} - ({unit.Manager})";
                    childNode.Text = text;
                }
                else
                {
                    childNode = new TreeNode(child.Name);
                }
                if (childNode != null)
                {
                    childNode.Tag = child;
                    main.Nodes.Add(childNode);
                }
            }
            return main;
        }

        public static string GetHierarchicalPath(this IHierarchical hierarchy)
        {

            //TODO buradaki kod yazılacak
            return string.Empty;
        }
    }
}
