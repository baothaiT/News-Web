using System;
using System.Collections.Generic;

namespace News.Entities
{
    public class Submission
    {
        public string submission_Id { get; set; }
        public string submission_Name { get; set; }
        public string submission_Description { get; set; }
        public DateTime submission_StartTime { set; get; }
        public DateTime v_DueTime { set; get; }
        public List<Idea> IdeaList { get; set; }

    }
}
