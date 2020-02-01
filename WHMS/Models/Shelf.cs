using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class Shelf
    {
        public int Id { get; set; }
        public int WareHouseID { get; set; }
        public WareHouse WareHouse { get; set; }
        public string Code { get; set; }

    }
}