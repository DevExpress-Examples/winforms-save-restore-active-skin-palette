Namespace DXApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.skinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
            Me.skinPaletteRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.skinRibbonGalleryBarItem1, Me.skinPaletteRibbonGalleryBarItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 7
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(758, 158)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            ' 
            ' skinRibbonGalleryBarItem1
            ' 
            Me.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1"
            Me.skinRibbonGalleryBarItem1.Id = 1
            Me.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1"
            ' 
            ' skinPaletteRibbonGalleryBarItem1
            ' 
            Me.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1"
            Me.skinPaletteRibbonGalleryBarItem1.Id = 6
            Me.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ribbonPage1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.skinRibbonGalleryBarItem1)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.skinPaletteRibbonGalleryBarItem1)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Skin"
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 336)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(758, 24)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.labelControl7)
            Me.layoutControl1.Controls.Add(Me.labelControl6)
            Me.layoutControl1.Controls.Add(Me.labelControl5)
            Me.layoutControl1.Controls.Add(Me.labelControl4)
            Me.layoutControl1.Controls.Add(Me.labelControl3)
            Me.layoutControl1.Controls.Add(Me.labelControl2)
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 158)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(758, 178)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.Location = New System.Drawing.Point(134, 49)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(63, 13)
            Me.labelControl4.StyleController = Me.layoutControl1
            Me.labelControl4.TabIndex = 7
            Me.labelControl4.Text = "labelControl4"
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Location = New System.Drawing.Point(12, 49)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(84, 13)
            Me.labelControl3.StyleController = Me.layoutControl1
            Me.labelControl3.TabIndex = 6
            Me.labelControl3.Text = "Settings.Palette: "
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(12, 32)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(96, 13)
            Me.labelControl2.StyleController = Me.layoutControl1
            Me.labelControl2.TabIndex = 5
            Me.labelControl2.Text = "Settings.SkinName: "
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(134, 32)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(63, 13)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 4
            Me.labelControl1.Text = "labelControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(758, 178)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.labelControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(122, 20)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(616, 17)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.labelControl2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 20)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(122, 17)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.labelControl3
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 37)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(122, 17)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.labelControl4
            Me.layoutControlItem4.Location = New System.Drawing.Point(122, 37)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(616, 17)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' labelControl5
            ' 
            Me.labelControl5.Location = New System.Drawing.Point(12, 66)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(118, 13)
            Me.labelControl5.StyleController = Me.layoutControl1
            Me.labelControl5.TabIndex = 8
            Me.labelControl5.Text = "Settings.CompactMode: "
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.labelControl5
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(122, 104)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' labelControl6
            ' 
            Me.labelControl6.Location = New System.Drawing.Point(134, 66)
            Me.labelControl6.Name = "labelControl6"
            Me.labelControl6.Size = New System.Drawing.Size(63, 13)
            Me.labelControl6.StyleController = Me.layoutControl1
            Me.labelControl6.TabIndex = 9
            Me.labelControl6.Text = "labelControl6"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.labelControl6
            Me.layoutControlItem6.Location = New System.Drawing.Point(122, 54)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(616, 104)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' labelControl7
            ' 
            Me.labelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 10F)
            Me.labelControl7.Appearance.Options.UseFont = True
            Me.labelControl7.Location = New System.Drawing.Point(12, 12)
            Me.labelControl7.Name = "labelControl7"
            Me.labelControl7.Size = New System.Drawing.Size(142, 16)
            Me.labelControl7.StyleController = Me.layoutControl1
            Me.labelControl7.TabIndex = 10
            Me.labelControl7.Text = "Values stored in Settings"
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.labelControl7
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(738, 20)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(758, 360)
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "Form1"
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private skinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem

        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private skinPaletteRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private labelControl6 As DevExpress.XtraEditors.LabelControl

        Private labelControl5 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private labelControl7 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
