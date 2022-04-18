using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class AssignToDepartment
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string CreateDate { get; set; }
        public string Description { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }

    }
}
