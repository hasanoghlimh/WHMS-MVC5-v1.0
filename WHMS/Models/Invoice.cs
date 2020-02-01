using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int PaymentInfoID { get; set; }
        public PaymentInfo PaymentInfo { get; set; }
        public int PreInvoiceID { get; set; }
        public PreInvoice PreInvoice { get; set; }
        public DateTime sendDate { get; set; }
        public string ShippingAddress { get; set; }
        public int StatusID { get; set; }
        public Status Status { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }



    }
}