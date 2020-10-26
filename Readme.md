<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DXApplication1/Form1.cs) (VB: [Form1.vb](./VB/DXApplication1/Form1.vb))
* [Program.cs](./CS/DXApplication1/Program.cs) (VB: [Program.vb](./VB/DXApplication1/Program.vb))
<!-- default file list end -->
# How to save/restore the applied skin and palette between application sessions 


<p>
<a href="https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/application-settings-for-windows-forms?view=netframeworkdesktop-4.8">Windows Forms Application Settings</a>  feature allows you to create, store, and maintain custom application and user preferences on client computers. You can use this feature to save and restore active skins and palettes when your application restarts.
Double-click the "Settings.settings" file in the Visual Studio Solution Explorer and create two entries of the String type. Set the scope of both entries to "User". When an application is about to close, save values of the UserLookAndFeel.Default.SkinName and UserLookAndFeel.Default.ActiveSvgPaletteName properties to Application Settings. When an application starts, read these saved values and pass them to the UserLookAndFeel.SetSkinStyle method as parameters.
</p>

<p>
See also: 
<br/> <a href="https://supportcenter.devexpress.com/ticket/details/t578454/svg-skins-and-palettes-faq">SVG Skins and Palettes – FAQ</a>
<br/> <a href="https://supportcenter.devexpress.com/ticket/details/t904174/devexpress-winforms-cheat-sheet-appearances-and-skins">DevExpress WinForms Cheat Sheet - Appearances and Skins</a>
<br/> <a href="http://msdn.microsoft.com/en-us/library/k4s6c3a0.aspx">Application Settings Overview</a>
</p>


