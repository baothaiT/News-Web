using System.Collections.Generic;

namespace News.Entities
{
    public class Categories
    {
        public string category_Id { get; set; }
        
        public string category_Name { get; set; }
        public string category_Description { get; set; }
        public bool IsDelete { set; get; }

        public List<Idea> IdeaList { get; set; }
    }
}
