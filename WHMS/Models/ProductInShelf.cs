using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class ProductInShelf
    {
        public int Id { get; set; }
        public int ShelfID { get; set; }
        public Shelf Shelf { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

    }
}