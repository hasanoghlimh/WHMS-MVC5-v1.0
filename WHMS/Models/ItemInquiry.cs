using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class ItemInquiry
    {
        public int Id { get; set; }
        public int OrderItemID { get; set; }
        public OrderItem OrderItem { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public bool inStock { get; set; }
        public int CurrencyUnitID { get; set; }
        public CurrencyUnit CurrencyUnit { get; set; }
        public int PreInvoiceID { get; set; }
        public PreInvoice PreInvoice { get; set; }
        public DateTime DateTime { get; set; }
        public int ItemPriceInUnit { get; set; }

    }
}