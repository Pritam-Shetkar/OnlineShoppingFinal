using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class Product
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public string PColor { get; set; }
        public string PType { get; set; }
        public string PSize { get; set; }
        public int? PPrize { get; set; }
    }
}
