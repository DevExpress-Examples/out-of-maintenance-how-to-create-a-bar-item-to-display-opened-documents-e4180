<!-- default file list -->
*Files to look at*:

* [BarWindowsButtonItem.xaml](./CS/OpenedWindows/BarWindowsButtonItem.xaml) (VB: [BarWindowsButtonItem.xaml.vb](./VB/OpenedWindows/BarWindowsButtonItem.xaml.vb))
* [BarWindowsButtonItem.xaml.cs](./CS/OpenedWindows/BarWindowsButtonItem.xaml.cs) (VB: [BarWindowsButtonItem.xaml.vb](./VB/OpenedWindows/BarWindowsButtonItem.xaml.vb))
* [DocumentsConverter.cs](./CS/OpenedWindows/DocumentsConverter.cs) (VB: [DocumentsConverter.vb](./VB/OpenedWindows/DocumentsConverter.vb))
* [MainWindow.xaml](./CS/OpenedWindows/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/OpenedWindows/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/OpenedWindows/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/OpenedWindows/MainWindow.xaml.vb))
* [MDIStyleConverter.cs](./CS/OpenedWindows/MDIStyleConverter.cs) (VB: [MDIStyleConverter.vb](./VB/OpenedWindows/MDIStyleConverter.vb))
<!-- default file list end -->
# How to create a bar item to display opened documents


<p>This example demonstrates how to create a bar item that will display all the opened documents with the possibility of changing the active one regardless of the position and parent group of the document. To do this, a BarSplitButtonItem descendant is created with a new property DockManager used to determine where to get the documents from.</p>

<br/>


