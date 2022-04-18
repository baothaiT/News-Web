using System;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class AssignToRoleModels
    {
        [Key]
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
