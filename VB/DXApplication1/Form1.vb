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

        Private Sub SetSkin(ByVal skinName As String)
            UserLookAndFeel.Default.SetSkinStyle(skinName)
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
            My.Settings.Default("SkinName") = UserLookAndFeel.Default.SkinName
            If UserLookAndFeel.Default.SkinName = "The Bezier" Then
                My.Settings.Default("Palette") = UserLookAndFeel.Default.ActiveSvgPaletteName
            End If
            My.Settings.Default.Save()
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            RestorePalette()
        End Sub

        Private Sub RestorePalette()
            If My.Settings.Default("SkinName") IsNot Nothing AndAlso My.Settings.Default("SkinName").ToString() <> String.Empty Then
                If My.Settings.Default("SkinName").ToString() = "The Bezier" AndAlso My.Settings.Default("Palette") IsNot Nothing AndAlso My.Settings.Default("Palette").ToString() <> String.Empty Then
                    UserLookAndFeel.Default.SetSkinStyle(My.Settings.Default("SkinName").ToString(), My.Settings.Default("Palette").ToString())
                Else
                    SetSkin(My.Settings.Default("SkinName").ToString())
                End If

            ElseIf My.Settings.Default("Palette") IsNot Nothing AndAlso My.Settings.Default("Palette").ToString() <> String.Empty Then
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier, My.Settings.Default("Palette").ToString())
            End If
        End Sub
    End Class
End Namespace
