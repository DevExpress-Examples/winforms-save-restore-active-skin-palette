Imports DevExpress.LookAndFeel
Imports DXApplication1.Properties
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DXApplication1

    Public Partial Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            AddHandler FormClosing, AddressOf Form1_FormClosing
        End Sub

        Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            SavePalette()
        End Sub

        Private Sub ShowSwatchPicker(ByVal owner As Form)
            Using dialog = New DevExpress.Customization.SvgSkinPaletteSelector(owner)
                dialog.ShowDialog()
                SavePalette()
            End Using
        End Sub

        Private Sub SavePalette()
            Dim settings = Properties.Settings.Default
            settings.SkinName = UserLookAndFeel.Default.SkinName
            settings.Palette = UserLookAndFeel.Default.ActiveSvgPaletteName
            settings.CompactMode = UserLookAndFeel.Default.CompactUIModeForced
            settings.Save()
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            RestorePalette()
            ShowSettings()
        End Sub

        Private Sub RestorePalette()
            Dim settings = Properties.Settings.Default
            If Not String.IsNullOrEmpty(settings.SkinName) Then
                If settings.CompactMode Then UserLookAndFeel.ForceCompactUIMode(True, False)
                If Not String.IsNullOrEmpty(settings.Palette) Then
                    UserLookAndFeel.Default.SetSkinStyle(settings.SkinName, settings.Palette)
                Else
                    UserLookAndFeel.Default.SetSkinStyle(settings.SkinName)
                End If
            End If
        End Sub

        Private Sub ShowSettings()
            labelControl1.Text = Settings.Default.SkinName
            labelControl4.Text = If(Not Equals(Settings.Default.Palette, String.Empty), Settings.Default.Palette, "n/a (default palette or raster skin)")
            labelControl6.Text = If(Settings.Default.CompactMode, "Yes", "No")
        End Sub
    End Class
End Namespace
