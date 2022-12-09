using System;
using System.Collections.Generic;

#nullable disable

namespace Shopping.Models
{
    public partial class User
    {
        public int CId { get; set; }
        public string CFname { get; set; }
        public string CLname { get; set; }
        public string CEmailId { get; set; }
        public string CMobileNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UsType { get; set; }
    }
}
