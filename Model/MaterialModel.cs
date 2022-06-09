using System;
using System.Collections.Generic;
using System.Text;

namespace LCC.Model
{
    public class MaterialModel
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public string description { get; set; }
        public string grade { get; set; }
        public double kerf { get; set; }
        public double trim_left { get; set; }
        public double trim_right { get; set; }
        public double part_allowance { get; set; }
        public double min_remnant_length { get; set; }
    }

    public class MaterialDescAndGradeModel
    {
        public string description { get; set; }
        public string grade { get; set; }
        public string formatted { get; set; }
    }
}
