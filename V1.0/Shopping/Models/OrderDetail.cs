using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class OrderDetail
    {
        public string OrderId { get; set; }
        public int? PId { get; set; }
        public int? CId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Address { get; set; }
    }
}
