'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace DXApplication1.Properties

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")>
    Friend NotInheritable Partial Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As DXApplication1.Properties.Settings = CType((Global.System.Configuration.ApplicationSettingsBase.Synchronized(New DXApplication1.Properties.Settings())), DXApplication1.Properties.Settings)

        Public Shared ReadOnly Property [Default] As Settings
            Get
                Return DXApplication1.Properties.Settings.defaultInstance
            End Get
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.DefaultSettingValueAttribute("")>
        Public Property SkinName As String
            Get
                Return(CStr((Me("SkinName"))))
            End Get

            Set(ByVal value As String)
                Me("SkinName") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.DefaultSettingValueAttribute("")>
        Public Property Palette As String
            Get
                Return(CStr((Me("Palette"))))
            End Get

            Set(ByVal value As String)
                Me("Palette") = value
            End Set
        End Property
    End Class
End Namespace