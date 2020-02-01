using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class WHHandling
    {
        public int Id { get; set; }
        public int FromShelfID { get; set; }
        public Shelf FromShelf { get; set; }
        public int ToShelfID { get; set; }
        public Shelf ToShelf { get; set; }
        public int QTY { get; set; }
        public Employee Employee { get; set; }
    }
}