using System;
using System.ComponentModel;

namespace News.Models
{
    public class DetailIdeaModels
    {
        public string idea_Id { get; set; }
        public string idea_Title { get; set; }
        public string idea_Description { get; set; }
        public DateTime idea_UpdateTime { get; set; }
        public string idea_ImageName { get; set; }

        [DisplayName("Category")]
        public string idea_CategoryName { get; set; }

        [DisplayName("Academic Year")]
        public string idea_SubmissionName { get; set; }

        [DisplayName("User")]
        public string idea_UserName { get; set; }
    }
}
