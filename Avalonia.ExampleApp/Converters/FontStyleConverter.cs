﻿using Avalonia.Data.Converters;
using Avalonia.ExtendedToolkit.Font;
using Avalonia.Media;
using System;
using System.Globalization;

namespace Avalonia.ExampleApp.Converters
{
    public class FontStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fs = (FontStyle)value;
            return fs == FontStyles.Italic;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                bool isSet = (bool)value;

                if (isSet)
                {
                    return FontStyles.Italic;
                }
            }

            return FontStyles.Normal;
        }
    }
}
