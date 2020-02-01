using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class Draft
    {
        public int Id { get; set; }
        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }

    }
}