using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class OrderViewModel
    {
        public String Id { get; set; }
        public int? PId { get; set; }
        public int? CId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Address { get; set; }
    }
}
