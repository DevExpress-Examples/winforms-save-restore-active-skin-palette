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

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			ShowSwatchPicker(Me)
		End Sub

		Private Sub ShowSwatchPicker(ByVal owner As Form)
			Using dialog = New DevExpress.Customization.SvgSkinPaletteSelector(owner)
				dialog.ShowDialog()
				SavePalette()
			End Using
		End Sub

		Private Sub SavePalette()
'INSTANT VB NOTE: The variable settings was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim settings_Conflict = My.Settings.Default
			settings_Conflict.SkinName = UserLookAndFeel.Default.SkinName
			settings_Conflict.Palette = UserLookAndFeel.Default.ActiveSvgPaletteName
			settings_Conflict.Save()
		End Sub

		Protected Overrides Sub OnShown(ByVal e As EventArgs)
			MyBase.OnShown(e)
			RestorePalette()
		End Sub

		Private Sub RestorePalette()
'INSTANT VB NOTE: The variable settings was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim settings_Conflict = My.Settings.Default
			If Not String.IsNullOrEmpty(settings_Conflict.SkinName) Then
				If Not String.IsNullOrEmpty(settings_Conflict.SkinName) Then
					UserLookAndFeel.Default.SetSkinStyle(settings_Conflict.SkinName, settings_Conflict.Palette)
				Else
					UserLookAndFeel.Default.SetSkinStyle(settings_Conflict.SkinName)
				End If
			End If
		End Sub
	End Class
End Namespace
