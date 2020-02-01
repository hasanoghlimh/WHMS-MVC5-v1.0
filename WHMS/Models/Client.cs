using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int PersonalInfoID { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public Group Group { get; set; }
        public bool IsColeg { get; set; }
    }
}