/**
 * @package LCC.Model
 * @author Empatech
 */
namespace LCC.Model
{
    public class ProjectModel {

        public int id { get; set; }
        public string project_reference { get; set; }
        public string project_name { get; set; }
        public string scope { get; set; }
        public string rev_no { get; set; }
    }

    public class ProjectMaterialModel
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public int material_id { get; set; }
    }
}