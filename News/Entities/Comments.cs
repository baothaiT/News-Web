using System;
using System.ComponentModel;

namespace News.Entities
{
    public class Comments
    {
        public string cmt_Id { get; set; }
        [DisplayName("Content")]
        public string cmt_Content { get; set; }
        public string cmt_UserId { get; set; }
        public AppUser AppUserFk { get; set; }
        [DisplayName("Update Date")]
        public DateTime cmt_UpdateDate { get; set; }
        public string cmt_IdeaId { get; set; }
        public Idea IdeaFk { get; set; }
        [DisplayName("Hiden")]
        public bool IsDelete { get; set; }

    }
}
