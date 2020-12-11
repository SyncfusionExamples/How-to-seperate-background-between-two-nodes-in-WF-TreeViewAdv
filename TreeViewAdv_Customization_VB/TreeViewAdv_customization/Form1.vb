Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Partial Public Class Form1
    Inherits MetroForm
    Public Sub New()
        InitializeComponent()

        Dim treeViewAdv1 As New TreeViewAdv()
        treeViewAdv1.Name = "treeView1"
        treeViewAdv1.Size = New Size(209, 241)
        treeViewAdv1.Location = New Point(159, 39)
        treeViewAdv1.Style = TreeStyle.Office2016Colorful

        'Create instance of TreeNodeAdv named treeNode1
        Dim treeNode1 As New TreeNodeAdv("Node1")
        Dim treeNode7 As New TreeNodeAdv("Node7")

        'Adding the subnode of [treeNode1] in Root [treeNode2].
        Dim treeNode2 As New TreeNodeAdv("Node0", New TreeNodeAdv() {treeNode1, treeNode7})
        treeNode2.Expanded = True

        'Create instance of TreeNodeAdv named treeNode3
        Dim treeNode3 As New TreeNodeAdv("Node3")
        Dim treeNode8 As New TreeNodeAdv("Node8")

        'Adding the subnode of [treeNode3 ] in Root [treeNode4].
        Dim treeNode4 As New TreeNodeAdv("Node2", New TreeNodeAdv() {treeNode3, treeNode8})
        treeNode4.Expanded = True

        ' Create instance of TreeNodeAdv named treeNode5
        Dim treeNode5 As New TreeNodeAdv("Node5")
        Dim treeNode9 As New TreeNodeAdv("Node9")

        'Adding the subnode of [treeNode5] in Root [treeNode6].
        Dim treeNode6 As New TreeNodeAdv("Node4", New TreeNodeAdv() {treeNode5, treeNode9})
        treeNode6.Expanded = True

        'Assigning the text and Name

        treeNode1.Name = "Node1"
        treeNode1.Text = "India"

        treeNode7.Name = "Node7"
        treeNode7.Text = "China"

        treeNode2.Name = "Node0"
        treeNode2.Text = "Asia"

        treeNode3.Name = "Node3"
        treeNode3.Text = "Britain"

        treeNode8.Name = "Node8"
        treeNode8.Text = "France"

        treeNode4.Name = "Node2"
        treeNode4.Text = "Europe"

        treeNode5.Name = "Node5"
        treeNode5.Text = "South Africa"

        treeNode9.Name = "Node9"
        treeNode9.Text = "Zimbabwe"

        treeNode6.Name = "Node4"
        treeNode6.Text = "Africa"

        'Add the nodes in TreeViewAdv nodes collection

        treeViewAdv1.Nodes.AddRange(New TreeNodeAdv() {treeNode2, treeNode4, treeNode6})


        treeViewAdv1.OwnerDrawNodes = True
        Me.StartPosition = FormStartPosition.CenterScreen
        AddHandler treeViewAdv1.BeforeNodePaint, AddressOf TreeViewAdv1_BeforeNodePaint1

        ' Add the TreeViewAdv to the Form controls
        Me.Controls.Add(treeViewAdv1)

    End Sub

    'Customize Background of Nodes
    Private Sub TreeViewAdv1_BeforeNodePaint1(ByVal sender As Object, ByVal e As TreeNodeAdvPaintEventArgs)
        Dim lBrush As New LinearGradientBrush(e.Node.Bounds, Color.LightGreen, Color.LightSeaGreen, LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(lBrush, e.Node.Bounds)
        e.Graphics.DrawRectangle(New Pen(Color.Red), e.Node.Bounds)
    End Sub


End Class