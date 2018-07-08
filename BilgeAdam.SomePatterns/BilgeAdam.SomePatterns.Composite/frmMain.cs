using BilgeAdam.SomePatterns.Composite.Helpers;
using BilgeAdam.SomePatterns.Composite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.SomePatterns.Composite
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var company = new Unit { Name = "Horfin" };

            var can1 = new Employee { Name = "Can PERK" };
            var can2 = new Employee { Name = "Can LALE" };
            var burcu = new Employee { Name = "Burcu CİRİTCİ" };
            var ecem = new Employee { Name = "Ecem DOĞDU" };
            var burcu2 = new Employee { Name = "Burcu YİĞİT" };
            var berkay = new Employee { Name = "Berkay EMİR" };
            var arda = new Employee { Name = "Arda ESEN" };


            company.Manager = can1;
            var finance = new Unit { Name = "Finance" };
            finance.Manager = can2;
            finance.Add(burcu2).Add(arda);

            var saadet = new Employee { Name = "Saadet ÇALIŞ" };
            var omer = new Employee { Name = "Ömer KORKMAZ" };
            var economy = new Unit { Name = "Ekonomi", Manager = saadet };
            var ahmet = new Employee { Name = "Ahmet YILMAZ" };
            economy.Add(ahmet);
            var sales = new Unit { Name = "Satış", Manager = omer };
            var mehmet = new Employee { Name = "Mehmet KARA" };
            var yelda = new Employee { Name = "Yelda AYDIN" };
            sales.Add(mehmet).Add(yelda);

            finance.Add(economy).Add(sales);


            var development = new Unit { Name = "Development" };
            development.Manager = burcu;
            development.Add(berkay).Add(ecem);

            company.Add(finance).Add(development);
             
            var root = company.ConvertToNode();
            trvHierarchy.Nodes.Add(root);
        }

        private void trvHierarchy_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //TreeView ve TreeNode ile yapılan yol
            //var parent = GetParent(e.Node);
            //txtPath.Text = parent;


            //Oluşturulan yapı üzerinden yapılan yol
            var tag = e.Node.Tag as IHierarchical;
            txtPath.Text = tag.GetPath();
        }

        private string GetParent(TreeNode node)
        {
            var path = string.Empty;
            var tag = node.Tag as IHierarchical;
            var parent = node.Parent;
            if (parent != null)
            {
                path = GetParent(parent);
            }
            else
            {
                return tag.ToString();
            }
            return $"{path}/{tag}";
        }
    }
}
