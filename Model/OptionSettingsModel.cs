namespace LCC.Model
{
    public class OptionSettingsModel
    {

        public int id { get; set; }
        public string type { get; set; }
        public string precision { get; set; }
        public string unit { get; set; }
        public bool zero_supression_leading { get; set; }
        public bool zero_supression_trailing { get; set; }

    }
}