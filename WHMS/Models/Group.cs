using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isAffiliate { get; set; }
        public int DiscountRate { get; set; }
        public int RegisteredByID { get; set; }
        public Employee RegisteredBy { get; set; }
    }
}