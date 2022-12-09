using Microsoft.AspNetCore.Mvc;
using Shopping.Interface;
using Shopping.Models;
using Shopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    // [Route("api/[controller]/[action]")]
    [Route("api/[controller]")]
    [ApiController]
   
    public class LoginController : Controller
    {


        private readonly ONLine_ShoppingContext db;
        private readonly IJWTMangerRepository iJWTMangerRepository;



        public LoginController(ONLine_ShoppingContext _db, IJWTMangerRepository _iJWTMangerRepository)
        {
            db = _db;
            iJWTMangerRepository = _iJWTMangerRepository;
        }
        [HttpGet]
        [Route("Adding")]
        public string Add()
        {
            return "Hello";
        }
        [HttpPost]
        [Route("Logging")]
        public IActionResult LoginMethod(LoginViewModel loginViewModel)
        {
            var token = iJWTMangerRepository.Authenticate(loginViewModel, false);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }

        //[HttpPost]
        //[Route("Registration")]
        //public IActionResult Register(RegisterViewModel registerViewModel)
        //{
        //    var token = iJWTMangerRepository.Authenticate(registerViewModel, true);
        //    if (token == null)
        //    {
        //        return Unauthorized();
        //    }
        //    return Ok(token);
        //}
    }
}
