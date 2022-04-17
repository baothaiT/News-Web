using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace News.Entities
{
    public class Submission
    {
        public string submission_Id { get; set; }
        [DisplayName("Submission Name")]
        public string submission_Name { get; set; }
        [DisplayName("Submission Description")]
        public string submission_Description { get; set; }
        [DisplayName("Submission Start time")]
        public DateTime submission_StartTime { set; get; }
        [DisplayName("Submission Due Time")]
        public DateTime submission_DueTime { set; get; }
        public bool IsDelete { set; get; }

        public string submission_UserId { set; get; }
        public AppUser userFK { get; set; }
        public List<Idea> IdeaList { get; set; }

    }
}
