using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WHMS.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int parentCategoryID { get; set; }
        public Category ParentCategory1 { get; set; }
    }
}