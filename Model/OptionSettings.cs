using System;
using System.Collections.Generic;
using System.Text;

namespace LCC.Model
{
    public class OptionSettings
    {
        public string measureType { get; set; }
        public double measurePrecision { get; set; }
        public string measureUnit { get; set; }
        public bool isLeadingChecked { get; set; }
        public bool isTrailingChecked { get; set; }
        public int costDecimalPlaces { get; set; }
        public string costSymbol { get; set; }
        public string costNumericCode { get; set; }
    }
}
