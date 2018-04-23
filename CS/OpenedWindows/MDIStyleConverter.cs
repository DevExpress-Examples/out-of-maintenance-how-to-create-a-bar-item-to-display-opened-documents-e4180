using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;
using System.Globalization;
using DevExpress.Xpf.Docking;

namespace OpenedWindows
{
    public class MDIStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (MDIStyle)value == MDIStyle.MDI;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.Equals(true) ? MDIStyle.MDI : MDIStyle.Tabbed;
        }
    }
}
