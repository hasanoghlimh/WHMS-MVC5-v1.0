using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int TrackingNo { get; set; }
        public int StatusID { get; set; }
        public Status Status { get; set; }

    }
}