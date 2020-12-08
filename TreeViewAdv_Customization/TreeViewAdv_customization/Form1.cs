using Syncfusion.Windows.Forms;
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
            this.treeViewAdv1.OwnerDrawNodes = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.treeViewAdv1.BeforeNodePaint += TreeViewAdv1_BeforeNodePaint1;
        }

        //Customize Background of Nodes
        private void TreeViewAdv1_BeforeNodePaint1(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventArgs e)
        {
            LinearGradientBrush lBrush = new LinearGradientBrush(e.Node.Bounds, Color.LightGreen, Color.LightSeaGreen, LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(lBrush, e.Node.Bounds);
            e.Graphics.DrawRectangle(new Pen(Color.Red), e.Node.Bounds);
        }
      
      
    }
}
