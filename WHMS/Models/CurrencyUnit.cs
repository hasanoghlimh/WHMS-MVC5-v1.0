using System;

namespace WHMS.Models
{
    public class CurrencyUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public DateTime RateLastUpdate { get; set; }
    }
}