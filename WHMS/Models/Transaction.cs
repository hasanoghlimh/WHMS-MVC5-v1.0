using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int FromProductInShelfID { get; set; }
        public ProductInShelf FromProductInShelf { get; set; }
        public int ToProductInShelfID { get; set; }
        public ProductInShelf ToProductInShelf { get; set; }
        public int QTY { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int DraftID { get; set; }
        public Draft Draft { get; set; }

    }
}