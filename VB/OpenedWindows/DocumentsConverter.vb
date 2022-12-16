Imports System
Imports System.Windows.Data
Imports System.Globalization
Imports DevExpress.Xpf.Docking
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Layout.Core

Namespace OpenedWindows

    Public Class DocumentsConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim manager As DockLayoutManager = TryCast(value, DockLayoutManager)
            Dim documents As ObservableCollection(Of Object) = New ObservableCollection(Of Object)()
            For Each item As BaseLayoutItem In manager.GetItems()
                If item.ItemType = LayoutItemType.Document AndAlso Not item.Closed Then documents.Add(item)
            Next

            Return documents
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return value
        End Function
    End Class
End Namespace
