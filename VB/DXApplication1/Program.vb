Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.UserSkins
Imports DevExpress.Skins

Namespace DXApplication1
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			BonusSkins.Register()
			SkinManager.EnableFormSkins()
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
