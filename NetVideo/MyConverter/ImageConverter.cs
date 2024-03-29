﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace NetVideo.MyConverter
{
    class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fileName = (String)value;
            var currentFolder = System.IO.Directory.GetCurrentDirectory();
            var baseFolder = System.IO.Directory.GetParent(System.IO.Directory.GetParent(currentFolder).FullName).FullName;
            var fullPath = baseFolder + "\\Images\\" + fileName;
            return fullPath;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
