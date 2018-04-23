Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Bars

Namespace OpenedWindows
	Partial Public Class BarWindowsButtonItem
		Inherits BarSplitButtonItem
		Public Shared ReadOnly DockManagerProperty As DependencyProperty = DependencyProperty.Register("DockManager", GetType(DockLayoutManager), GetType(BarWindowsButtonItem), New PropertyMetadata(Nothing))

		Public Property DockManager() As DockLayoutManager
			Get
				Return CType(GetValue(DockManagerProperty), DockLayoutManager)
			End Get
			Set(ByVal value As DockLayoutManager)
				SetValue(DockManagerProperty, value)
			End Set
		End Property

		Shared Sub New()
			BarItemLinkCreator.Default.RegisterObject(GetType(BarWindowsButtonItem), GetType(BarSplitButtonItemLink), New CreateObjectMethod(Of BarItemLink)(Function(obj) New BarSplitButtonItemLink()))
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub onPopupOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			lbPopup.GetBindingExpression(ListBoxEdit.ItemsSourceProperty).UpdateTarget()
		End Sub

		Private Sub onSelectedWindowChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
			DockManager.DockController.Activate(TryCast((TryCast(sender, ListBoxEdit)).SelectedItem, BaseLayoutItem))
		End Sub
	End Class
End Namespace
