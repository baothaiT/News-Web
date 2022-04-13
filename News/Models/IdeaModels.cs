using Microsoft.AspNetCore.Http;
using News.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.Models
{
    public class IdeaModels
    {
        [Key]
        public string idea_Id { get; set; }
        public string idea_Title { get; set; }
        public string idea_Description { get; set; }
        public DateTime idea_UpdateTime { get; set; }
        public bool idea_Agree { get; set; }
        public string idea_ImageName { get; set; }
        [NotMapped]
        [DisplayName("Image (350x200)")]
        public IFormFile idea_ImagePath { get; set; }

        [DisplayName("Category")]
        public string idea_CategoryId { get; set; }

        [DisplayName("Academic Year")]
        public string idea_SubmissionId { get; set; }

        [DisplayName("User")]
        public string idea_UserId { get; set; }
    }
}
