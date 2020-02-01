using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsMGR { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public int PersonalInfoID { get; set; }
        public PersonalInfo PersonalInfo { get; set; }

    }
}