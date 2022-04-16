using System;

namespace News.Models
{
    public class CommentsModels
    {
        public string cmt_Id { get; set; }
        public string cmt_Content { get; set; }
        public string cmt_UserName { get; set; }
        public DateTime cmt_UpdateDate { get; set; }      
    }
}
