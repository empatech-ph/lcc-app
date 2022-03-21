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
        public double scrap_stock_length { get; set; }
        public double total_rest { get; set; }
        public double stock_length { get; set; }
        public double cutlength_length { get; set; }
        public double computed_cutlength_length { get; set; }
        public double kerf { get; set; }
        public double trim_left { get; set; }
        public double trim_right { get; set; }
        public double cost { get; set; }
        public string stock_type { get; set; }
        public string note { get; set; }
        public string optimize_type { get; set; }
    }

    public class TempStocklengthModel
    {
        public int cutlength_id { get; set; }
        public int material_id { get; set; }
        public string stock_code { get; set; }
        public double length { get; set; }
        public string stock_type { get; set; }
        public double scrap { get; set; }
        public double rest { get; set; }
        public double cost { get; set; }
        public int total_cut { get; set; }
        public int repeated { get; set; }
        public string note { get; set; }
        public string stock_desc_grade { get; set; }
        public double cutlength_length { get; set; }
        public double trim_left { get; set; }
        public double trim_right { get; set; }
        public double kerf { get; set; }
        public TempOptimizedModel data { get; set; }
    }

    public class TempCutlengthModel
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public string cutlength_desc_grade { get; set; }
        public int quantity { get; set; }
        public int uncut_quantity { get; set; }
        public double total_parts_length { get; set; }
        public double total_stock_length { get; set; }
        public double gross_yield { get; set; }
        public double cost { get; set; }
        public double total_layout { get; set; }
        public string part_code { get; set; }
        public string description { get; set; }
        public string grade { get; set; }
        public double length { get; set; }
        public string order_number { get; set; }
        public string note { get; set; }
    }

    public class TempFilteredOptimized
    {
        public int cutlength_id { get; set; }
        public double sum { get; set; }
        public string optimize_type { get; set; }
        public List<TempOptimizedModel> data { get; set; }
    }
}
