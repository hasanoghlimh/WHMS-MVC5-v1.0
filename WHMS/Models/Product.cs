using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WHMS.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int PartNo { get; set; }
        public int CurrencyUnitID { get; set; }
        public CurrencyUnit CurrencyUnit { get; set; }
        public int UnitID { get; set; }
        public Unit Unit { get; set; }
        public string Description { get; set; }
        public int ReOrderPoint { get; set; }
        public int Price { get; set; }


    }
}