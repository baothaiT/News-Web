﻿using Microsoft.AspNetCore.Http;
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
        public DateTime idea_UpdateTime { get; set; }
        public bool idea_Agree { get; set; }
        public string idea_ImageName { get; set; }

        [DisplayName("Image")]
        public string idea_ImagePath { get; set; }
        
        [DisplayName("Category")]
        public string idea_CategoryId { get; set; }
        public Categories categoriesFK { get; set; }

        [DisplayName("Academic Year")]
        public string idea_AcademicYearId { get; set; }
        public AcademicYear AcademicYearFK { get; set; }

        [DisplayName("User")]
        public string idea_UserId { get; set; }
        public AppUser appUserFK { get; set; }

    }
}
