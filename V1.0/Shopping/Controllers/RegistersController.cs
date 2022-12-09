using Microsoft.AspNetCore.Mvc;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class RegistersController : Controller
    {
        ONLine_ShoppingContext db;
        public RegistersController(ONLine_ShoppingContext _db)
        {
            db = _db;
        }
        [HttpPost("postCustomer")]
        public async Task<int> CreateCustomer(User user)
        {
            db.Users.Add(user);
            return await db.SaveChangesAsync();
        }
    }
}
