using System.Collections.Generic;

namespace News.Entities
{
    public class Department
    {
        public string department_Id { get; set; }
        public string department_Name { get; set; }
        public string department_Description { get; set; }
        public bool IsDelete { set; get; }

        public List<UserInDepartment> userInDepartmentsList { set; get; }

    }
}
