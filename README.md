# How to seperate background between two nodes in WinForms TreeViewAdv

This respository contains the sample that how to seperate the background between two nodes in [WinForms TreeViewAdv](https://www.syncfusion.com/winforms-ui-controls/treeview) control.

You can separate the background between two adjacent nodes in WinForms TreeViewAdv control by using [BeforeNodePaint](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Tools.TreeViewAdv.html#Syncfusion_Windows_Forms_Tools_TreeViewAdv_BeforeNodePaint) event. Refer the below code for your reference.

``` csharp
treeViewAdv1.BeforeNodePaint += TreeViewAdv1_BeforeNodePaint1;
 
//Customize Background of Nodes
private void TreeViewAdv1_BeforeNodePaint1(object sender, TreeNodeAdvPaintEventArgs e)
{
  LinearGradientBrush lBrush = new LinearGradientBrush(e.Node.Bounds, Color.LightGreen, Color.LightSeaGreen, LinearGradientMode.Horizontal);
  e.Graphics.FillRectangle(lBrush, e.Node.Bounds);
  e.Graphics.DrawRectangle(new Pen(Color.Red), e.Node.Bounds);
}
```

![](https://www.syncfusion.com/uploads/user/kb/wf/wf-57823/wf-57823_img1.png)