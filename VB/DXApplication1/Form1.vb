Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
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
            UserLookAndFeel.Default.SkinName = skinName
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
                Dim commonSkin = CommonSkins.GetSkin(UserLookAndFeel.Default)
                Dim customPallete As DevExpress.Utils.Svg.SvgPalette = commonSkin.SvgPalettes(Skin.DefaultSkinPaletteName).CustomPalette
                Dim name = commonSkin.CustomSvgPalettes.FirstOrDefault(Function(x) x.Value Is customPallete).Key?.Name
                My.Settings.Default("Palette") = name
            End If
            My.Settings.Default.Save()
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            RestorePalette()
        End Sub

        Private Sub RestorePalette()
            If My.Settings.Default("SkinName") IsNot Nothing AndAlso My.Settings.Default("SkinName").ToString() <> String.Empty Then
                SetSkin(My.Settings.Default("SkinName").ToString())
            Else
                UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier)
            End If
            If UserLookAndFeel.Default.SkinName = "The Bezier" Then
                If My.Settings.Default("Palette") IsNot Nothing AndAlso My.Settings.Default("Palette").ToString() <> String.Empty Then
                    Dim skin = CommonSkins.GetSkin(UserLookAndFeel.Default)
                    Dim palette As DevExpress.Utils.Svg.SvgPalette = skin.CustomSvgPalettes(My.Settings.Default("Palette").ToString())
                    If palette IsNot Nothing Then
                        skin.SvgPalettes(Skin.DefaultSkinPaletteName).SetCustomPalette(palette)
                        LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
                    End If
                End If
            End If
        End Sub

        Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            RestorePalette()
        End Sub

        Private Sub barButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            SavePalette()
        End Sub
    End Class
End Namespace
