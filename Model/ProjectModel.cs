using System;
/**
* @package LCC.Model
* @author Empatech
*/
namespace LCC.Model
{
    public class ProjectModel
    {
        string name;
        public int id { get; set; }
        public string project_reference { get; set; }
        public string project_name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                if (ProjectNameChanged != null)
                {
                    ProjectNameChanged();
                }
            }
        }
        public string scope { get; set; }
        public string rev_no { get; set; }
        public bool is_active { get; set; }
        public event Action ProjectReferenceChanged;
        public event Action ProjectNameChanged;
    }

    public class ProjectMaterialModel
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public int material_id { get; set; }
    }
}