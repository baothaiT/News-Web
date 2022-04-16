using System;

namespace News.Models
{
    public class BlogArchiveModels
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Img { get; set; }
        public string UserName { get; set; }
        public int CountComment { get; set; }
        public int View { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
