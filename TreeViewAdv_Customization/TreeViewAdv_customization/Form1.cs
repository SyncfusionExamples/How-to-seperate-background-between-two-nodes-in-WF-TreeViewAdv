using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewAdv_customization
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            TreeViewAdv treeViewAdv1 = new TreeViewAdv();            
            treeViewAdv1.Name = "treeView1";
            treeViewAdv1.Size = new Size(209, 241);
            treeViewAdv1.Location = new Point(159, 39);
            treeViewAdv1.Style = TreeStyle.Office2016Colorful;

            //Create instance of TreeNodeAdv named treeNode1
            TreeNodeAdv treeNode1 = new TreeNodeAdv("Node1");
            TreeNodeAdv treeNode7 = new TreeNodeAdv("Node7");

            //Adding the subnode of [treeNode1] in Root [treeNode2].
            TreeNodeAdv treeNode2 = new TreeNodeAdv("Node0", new TreeNodeAdv[] {
            treeNode1, treeNode7});
            treeNode2.Expanded = true;

            //Create instance of TreeNodeAdv named treeNode3
            TreeNodeAdv treeNode3 = new TreeNodeAdv("Node3");
            TreeNodeAdv treeNode8 = new TreeNodeAdv("Node8");

            //Adding the subnode of [treeNode3 ] in Root [treeNode4].
            TreeNodeAdv treeNode4 = new TreeNodeAdv("Node2", new TreeNodeAdv[] {
            treeNode3, treeNode8});
            treeNode4.Expanded = true;

            // Create instance of TreeNodeAdv named treeNode5
            TreeNodeAdv treeNode5 = new TreeNodeAdv("Node5");
            TreeNodeAdv treeNode9 = new TreeNodeAdv("Node9");

            //Adding the subnode of [treeNode5] in Root [treeNode6].
            TreeNodeAdv treeNode6 = new TreeNodeAdv("Node4", new TreeNodeAdv[] {
            treeNode5, treeNode9});
            treeNode6.Expanded = true;

            //Assigning the text and Name

            treeNode1.Name = "Node1";
            treeNode1.Text = "India";

            treeNode7.Name = "Node7";
            treeNode7.Text = "China";

            treeNode2.Name = "Node0";
            treeNode2.Text = "Asia";

            treeNode3.Name = "Node3";
            treeNode3.Text = "Britain";

            treeNode8.Name = "Node8";
            treeNode8.Text = "France";

            treeNode4.Name = "Node2";
            treeNode4.Text = "Europe";

            treeNode5.Name = "Node5";
            treeNode5.Text = "South Africa";

            treeNode9.Name = "Node9";
            treeNode9.Text = "Zimbabwe";

            treeNode6.Name = "Node4";
            treeNode6.Text = "Africa";

            //Add the nodes in TreeViewAdv nodes collection

            treeViewAdv1.Nodes.AddRange(new TreeNodeAdv[] {
            treeNode2,
            treeNode4,
            treeNode6});


            treeViewAdv1.OwnerDrawNodes = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            treeViewAdv1.BeforeNodePaint += TreeViewAdv1_BeforeNodePaint1;

            // Add the TreeViewAdv to the Form controls
            this.Controls.Add(treeViewAdv1);

        }

        //Customize Background of Nodes
        private void TreeViewAdv1_BeforeNodePaint1(object sender, TreeNodeAdvPaintEventArgs e)
        {
            LinearGradientBrush lBrush = new LinearGradientBrush(e.Node.Bounds, Color.LightGreen, Color.LightSeaGreen, LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(lBrush, e.Node.Bounds);
            e.Graphics.DrawRectangle(new Pen(Color.Red), e.Node.Bounds);
        }
      
      
    }
}
