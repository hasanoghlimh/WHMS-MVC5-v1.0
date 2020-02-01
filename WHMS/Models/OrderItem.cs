using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int RowNo { get; set; }
        public string Name { get; set; }
        public int QTY { get; set; }
        public string Description { get; set; }

    }
}