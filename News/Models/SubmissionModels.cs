using System;
using System.ComponentModel;

namespace News.Models
{
    public class SubmissionModels
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
        public bool Block { get; set; }
    }
}
