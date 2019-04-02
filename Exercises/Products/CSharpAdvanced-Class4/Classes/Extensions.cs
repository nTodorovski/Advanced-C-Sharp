using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvanced_Class4
{
    public static class Extensions
    {
        public static string PriceWithCurrency(this double value, string currency)
        {
            Console.OutputEncoding = Encoding.Default;
            var culture = (from c in CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                           let r = new RegionInfo(c.LCID)
                           where r != null
                           && r.ISOCurrencySymbol.ToUpper() == currency.ToUpper()
                           select c).FirstOrDefault();
            if (culture == null)
                return value.ToString("0.00");

            return string.Format(culture, "{0:C}", value);
        }
    }
}
