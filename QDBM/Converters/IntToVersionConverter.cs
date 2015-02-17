using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace QPAD.Converters
{
    [ValueConversion(typeof(int), typeof(string))]
    class IntToVersionConverter : 
#if !SILVERLIGHT
        MarkupExtension,
#endif
        IValueConverter
    {
        public IntToVersionConverter() { }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value == 0) { return ""; }
            int version = (int)value; //Semantic Versioning i.e Major.Minor.Patch

            /* Old Versioning system using release date.
            // I'm subtracting because I read somewhere that the modulus operator is expensive on memory.
            int year = date / 1000000;
            int month = (date - year * 1000000) / 10000;
            int day = (date - year * 1000000 - month * 10000) / 100;
            int build = (date - year * 1000000 - month * 10000 - day * 100);

            return year.ToString("0000") + "." + month.ToString("00") + "." + day.ToString("00") + "." + build.ToString("00");
            */
            

            int major = version / 10000;
            int minor = (version - major*10000) / 100;
            int patch = version % 100;
            return major.ToString() + "." + minor.ToString() + "." + patch.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string version = (string) value;
            return version.Replace(".", string.Empty);
        }
    }
}
