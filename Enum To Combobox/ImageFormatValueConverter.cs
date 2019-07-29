using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Windows.Data;

namespace Enum_To_Combobox
{
    public class ImageFormatValueConverter : IValueConverter
    {
        public IEnumerable<string> Strings => GetStrings();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ImageFormat format)
            {
                return GetString(format);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string s)
            {
                return Enum.Parse(typeof(ImageFormat), s.Substring(0, s.IndexOf(':')));
            }

            return null;
        }

        private static string GetString(ImageFormat format)
        {
            return format + ": " + GetDescription(format);
        }

        private static string GetDescription(ImageFormat format)
        {
            return format.GetType().GetMember(format.ToString())[0].GetCustomAttribute<DescriptionAttribute>().Description;
        }

        private static IEnumerable<string> GetStrings()
        {
            var list = new List<string>();
            foreach (ImageFormat format in Enum.GetValues(typeof(ImageFormat)))
            {
                list.Add(GetString(format));
            }

            return list.ToArray();
        }
    }
}
