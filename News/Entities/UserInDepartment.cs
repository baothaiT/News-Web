namespace News.Entities
{
    public class UserInDepartment
    {
        public string uid_UserId { get; set; }
        public AppUser AppUserFK { get; set; }
        public string uid_DepartmentId { get; set; }
        public Department DepartmentFK { get; set; }

    }
}
