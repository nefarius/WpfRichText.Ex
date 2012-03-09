== What's this? ==
This repository contains a fork of the [http://michaelsync.net/2009/06/09/bindable-wpf-richtext-editor-with-xamlhtml-convertor Bindable WPF RichText Editor with XAML/HTML Convertor] by Michael Sync.

Since the original implementation wasn't updated 'till 2009 and still contained some annoying bugs I allowed myself to create this improved version. Stuff I fixed:

* Foreign chars like é à è ä ö ü didn't work, changed encoding from ASCII to UTF8
* Visibility of the toolbar is controllable by user with the <code>ToolbarVisibility</code> property now for read-only purposes
* Height of the text editor itself can be set with the <code>EditorHeight</code> property

Oh and instead of a demo project it's a ready-to-use class library now :-)

Requires the .NET Framework 4.0