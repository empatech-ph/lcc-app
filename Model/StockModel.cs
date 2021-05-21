using System;
using System.Collections.Generic;
using System.Text;

namespace LCC.Model
{
    public class StockModel
    {
        public int id { get; set; }
        public int material_id { get; set; }
        public string qty { get; set; }
        public int length { get; set; }
        public string stock_type { get; set; }
        public double cost { get; set; }
        public string stock_code { get; set; }
        public string note { get; set; }
        public bool visibility { get; set; }
        public bool editable { get; set; }
    }
}
