Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils.Svg
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DXApplication1
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            AddHandler Me.FormClosing, AddressOf Form1_FormClosing
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
'INSTANT VB NOTE: The variable settings was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
            Dim settings_Renamed = My.Settings.Default
            settings_Renamed.SkinName = UserLookAndFeel.Default.SkinName
            settings_Renamed.Palette = UserLookAndFeel.Default.ActiveSvgPaletteName
            settings_Renamed.CompactMode = UserLookAndFeel.Default.CompactUIModeForced
            settings_Renamed.Save()
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            RestorePalette()
            ShowSettings()
        End Sub

        Private Sub RestorePalette()
'INSTANT VB NOTE: The variable settings was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
            Dim settings_Renamed = My.Settings.Default
            If Not String.IsNullOrEmpty(settings_Renamed.SkinName) Then
                If settings_Renamed.CompactMode Then
                    UserLookAndFeel.ForceCompactUIMode(True, False)
                End If
                If Not String.IsNullOrEmpty(settings_Renamed.Palette) Then
                    UserLookAndFeel.Default.SetSkinStyle(settings_Renamed.SkinName, settings_Renamed.Palette)
                Else
                    UserLookAndFeel.Default.SetSkinStyle(settings_Renamed.SkinName)
                End If
            End If
        End Sub

        Private Sub ShowSettings()
            labelControl1.Text = My.Settings.Default.SkinName
            labelControl4.Text = If(My.Settings.Default.Palette <> String.Empty, My.Settings.Default.Palette, "n/a (default palette or raster skin)")
            labelControl6.Text = If(My.Settings.Default.CompactMode, "Yes", "No")
        End Sub
    End Class
End Namespace
