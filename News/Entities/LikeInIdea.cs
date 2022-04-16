using System;

namespace News.Entities
{
    public class LikeInIdea
    {
        public string likeInIdea_Id { get; set; }
        public bool likeInIdea_Like { get; set; }
        public bool likeInIdea_DisLike { get; set; }
        public DateTime likeInIdea_CreateDate { get; set; }
        public string likeInIdea_UserId { get; set; } // AppUser
        public AppUser AppUser { get; set; }
        public string likeInIdea_IdeaId { get; set; } // Idea
        public Idea Idea { get; set; }
    }
}
