using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace News.Entities
{
    public class Idea
    {
        public string idea_Id { get; set; }
        public string idea_Title { get; set; }
        public string idea_Description { get; set; }
        public int idea_View { get; set; }
        public DateTime idea_UpdateTime { get; set; }
        public bool idea_Agree { get; set; }
        public string idea_ImageName { get; set; }

        [DisplayName("Image")]
        public string idea_ImagePath { get; set; }
        
        [DisplayName("Category")]
        public string idea_CategoryId { get; set; }
        public Categories categoriesFK { get; set; }

        [DisplayName("Submission")]
        public string idea_SubmissionId { get; set; }
        public Submission submissionFK { get; set; }

        [DisplayName("User")]
        public string idea_UserId { get; set; }
        public bool IsDelete { set; get; }
        public AppUser appUserFK { get; set; }

        public List<LikeInIdea> likeInIdea { set; get; }
        public List<Comments> Comments { set; get; }

    }
}
