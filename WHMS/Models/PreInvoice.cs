using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class PreInvoice
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public DateTime pubDateTime { get; set; }
        public DateTime expDateTime { get; set; }
        public int EmployeeID { get; set; }
        public Employee EmployeeE { get; set; }
        public int StatusID { get; set; }
        public Status Status { get; set; }
        public int TaxRate { get; set; }
        public int TotalPrice { get; set; }

    }
}