using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class DetailIdeaModels
    {
        [Key]
        public string idea_Id { get; set; }
        [DisplayName("Title")]
        public string idea_Title { get; set; }
        [DisplayName("Description")]
        public string idea_Description { get; set; }
        [DisplayName("Update Time")]
        public DateTime idea_UpdateTime { get; set; }
        [DisplayName("Image")]
        public string idea_ImageName { get; set; }

        [DisplayName("Category")]
        public string idea_CategoryName { get; set; }

        [DisplayName("Submission Name")]
        public string idea_SubmissionName { get; set; }

        [DisplayName("User")]
        public string idea_UserName { get; set; }
    }
}
