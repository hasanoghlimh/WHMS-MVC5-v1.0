using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public int NationalId { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


    }
}