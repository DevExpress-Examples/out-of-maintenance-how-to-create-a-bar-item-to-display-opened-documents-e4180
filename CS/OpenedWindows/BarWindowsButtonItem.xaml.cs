using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Bars;

namespace OpenedWindows
{
    public partial class BarWindowsButtonItem : BarSplitButtonItem
    {
        public static readonly DependencyProperty DockManagerProperty = DependencyProperty.Register("DockManager", typeof(DockLayoutManager), typeof(BarWindowsButtonItem), new PropertyMetadata(null));

        public DockLayoutManager DockManager
        {
            get
            {
                return (DockLayoutManager)GetValue(DockManagerProperty);
            }
            set
            {
                SetValue(DockManagerProperty, value);
            }
        }

        static BarWindowsButtonItem()
        {
            BarItemLinkCreator.Default.RegisterObject(typeof(BarWindowsButtonItem), typeof(BarSplitButtonItemLink), new CreateObjectMethod<BarItemLink>((obj) => new BarSplitButtonItemLink()));
        }

        public BarWindowsButtonItem()
        {
            InitializeComponent();
        }

        private void onPopupOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lbPopup.GetBindingExpression(ListBoxEdit.ItemsSourceProperty).UpdateTarget();
        }

        private void onSelectedWindowChanged(object sender, RoutedEventArgs e)
        {
            DockManager.DockController.Activate((sender as ListBoxEdit).SelectedItem as BaseLayoutItem);
        }
    }
}
