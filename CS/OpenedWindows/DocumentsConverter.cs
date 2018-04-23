using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;
using System.Globalization;
using DevExpress.Xpf.Docking;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Layout.Core;

namespace OpenedWindows
{
    public class DocumentsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DockLayoutManager manager = value as DockLayoutManager;
            ObservableCollection<object> documents = new ObservableCollection<object>();
            foreach (BaseLayoutItem item in manager.GetItems())
                if (item.ItemType == LayoutItemType.Document && !item.Closed)
                    documents.Add(item);
            return documents;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
