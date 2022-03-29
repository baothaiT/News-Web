using System.Collections.Generic;

namespace News.Entities
{
    public class AcademicYear
    {
        public string academicYear_Id { get; set; }
        public string academicYear_Name { get; set; }
        public string academicYear_Description { get; set; }
        public List<Idea> IdeaList { get; set; }

    }
}
