Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Data
Imports System.Globalization
Imports DevExpress.Xpf.Docking

Namespace OpenedWindows
	Public Class MDIStyleConverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			Return CType(value, MDIStyle) = MDIStyle.MDI
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return If(value.Equals(True), MDIStyle.MDI, MDIStyle.Tabbed)
		End Function
	End Class
End Namespace
