using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class UserType
    {
        public int Id { get; set; }
        public string UsType { get; set; }
        public bool? Isactive { get; set; }
    }
}
