using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class PaymentInfo
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int PreInvoiceID { get; set; }
        public PreInvoice PreInvoice { get; set; }
        public string TrackingCode { get; set; }
        public int Fee { get; set; }
        public string srcAccount { get; set; }
        public string dstAccount { get; set; }
        public bool Confirmed { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime RecievedDateTime { get; set; }
    }
}