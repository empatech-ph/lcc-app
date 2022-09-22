

namespace LCC.Model
{
    public class CutLengthModel
    {

        public int id { get; set; }
        public int project_id { get; set; }
        public string part_code { get; set; }
        public string description { get; set; }
        public string grade { get; set; }
        public int quantity { get; set; }
        public int uncut_quantity { get; set; }
        public double length { get; set; }
        public string order_number { get; set; }
        public string note { get; set; }

    }
}