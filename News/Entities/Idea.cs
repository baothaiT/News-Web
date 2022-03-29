using System;

namespace News.Entities
{
    public class Idea
    {
        public string idea_Id { get; set; }
        public string idea_Title { get; set; }
        public string idea_Description { get; set; }
        public DateTime idea_UpdateTime { get; set; }
        public string idea_CategoryId { get; set; }
        public Categories categoriesFK { get; set; }
        public string idea_AcademicYearId { get; set; }
        public AcademicYear AcademicYearFK { get; set; }
        public string idea_UserId { get; set; }
        public AppUser appUserFK { get; set; }

    }
}
