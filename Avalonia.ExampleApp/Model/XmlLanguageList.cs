using System;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Avalonia.ExampleApp.Model
{
    /// <summary>
    /// orginal XmlLanguage instead of string
    /// </summary>
    public class XmlLanguageList : ObservableCollection<string>
    {
        public XmlLanguageList()
        {
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                if (string.IsNullOrEmpty(ci.IetfLanguageTag))
                    continue;
                Add(ci.IetfLanguageTag);
            }
        }
    }
}
