using System;
using System.Collections.Generic;
using System.Text;

namespace LCC.Model
{
    public class TempOptimizedModel
    {
        public int id { get; set; }
        public int stock_id { get; set; }
        public int material_id { get; set; }
        public int cutlength_id { get; set; }
        public string stock_code { get; set; }
        public string cutlength_desc { get; set; }
        public string stock_desc_grade { get; set; }
        public int total_cut{ get; set; }
        public int total_uncut{ get; set; }
        public double remaining_stock_length{ get; set; }
        public double stock_length { get; set; }
        public double cutlength_length { get; set; }
    }

    public class TempStocklengthModel
    {
        public int cutlength_id { get; set; }
        public string stock_code { get; set; }
        public string stock_desc_grade { get; set; }
        public double length { get; set; }
        public double cutlength_length { get; set; }
        public double rest { get; set; }
        public int repeated { get; set; }
        public int total_cut { get; set; }
        public TempOptimizedModel data { get; set; }
    }

    public class TempCutlengthModel
    {
        public int cutlength_id { get; set; }
        public string part_code { get; set; }
        public string grade { get; set; }
        public string description { get; set; }
        public string cutlength_desc_grade { get; set; }
        public double length { get; set; }
        public int quantity { get; set; }
        public int uncut { get; set; }

        
    }
}
