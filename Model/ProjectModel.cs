
using ChoETL;
/**
* @package LCC.Model
* @author Empatech
*/
namespace LCC.Model
{
    public class ProjectModel {
        //[ChoCSVRecordField(1, AltFieldNames = "proj_Id")]
        public int id { get; set; }
        //[ChoCSVRecordField(1, AltFieldNames = "proj_Reference")]
        public string project_reference { get; set; }
        //[ChoCSVRecordField(1, AltFieldNames = "proj_Name")]
        public string project_name { get; set; }
        //[ChoCSVRecordField(1, AltFieldNames = "proj_Scope")]
        public string scope { get; set; }
        //[ChoCSVRecordField(1, AltFieldNames = "proj_Rev")]
        public string rev_no { get; set; }
    }

    public class ProjectMaterialModel
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public int material_id { get; set; }
    }
}