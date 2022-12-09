using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.ViewModel
{
    public class ProductViewModel
    {

        public int PId { get; set; }
        public string PName { get; set; }
        public string PColor { get; set; }
        public string PType { get; set; }
        public string PSize { get; set; }
        public int? PPrize { get; set; }
        public int? OrderDetails { get; set; }
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
