using System;
using System.Collections.Generic;
using System.Text;

namespace LCC.Model
{
    public class StockModel
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public int material_id { get; set; }
        public string description { get; set; }
        public string grade { get; set; }
        public string qty { get; set; }
        public double length { get; set; }
        public string stock_type { get; set; }
        public double cost { get; set; }
        public string stock_code { get; set; }
        public string note { get; set; }
        /**
         * stock
         * remnant
         * scrap
         */
        public string cut_stock_type { get; set; } = "stock";
        public int total_cost { get; set; } = 0;
        public bool visibility { get; set; }
        public bool editable { get; set; }
    }
}
