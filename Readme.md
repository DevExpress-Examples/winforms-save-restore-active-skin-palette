<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622187/22.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T581395)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Skins - Save/restore the active skin and palette between application sessions 

The [Windows Forms Application Settings](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/application-settings-for-windows-forms?view=netframeworkdesktop-4.8) feature allows you to create, store, and maintain user preferences on client computers. You can use this feature to save the active skin and palette and restore these settings when your application restarts.

* Double-click the *Settings.settings* file in the Visual Studio Solution Explorer.
* Create two entries of the `String` type.
* Set the scope of both entries to "User".
* When your application is about to close, save values of `UserLookAndFeel.Default.SkinName` and `UserLookAndFeel.Default.ActiveSvgPaletteName` properties to Application Settings.
* When your application starts, read saved settings and pass them to the `UserLookAndFeel.SetSkinStyle` method as parameters.

## Files to Review

* [Form1.cs](./CS/DXApplication1/Form1.cs) (VB: [Form1.vb](./VB/DXApplication1/Form1.vb))
* [Program.cs](./CS/DXApplication1/Program.cs) (VB: [Program.vb](./VB/DXApplication1/Program.vb))


## See Also

* [SVG Skins and Palettes – FAQ](https://supportcenter.devexpress.com/ticket/details/t578454/svg-skins-and-palettes-faq")
* [DevExpress WinForms Cheat Sheet - Appearances and Skins](https://supportcenter.devexpress.com/ticket/details/t904174/devexpress-winforms-cheat-sheet-appearances-and-skins)
* [Application Settings Overview](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/application-settings-overview?view=netframeworkdesktop-4.8)


