using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping.Models;
using Shopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductController : Controller
    {
        ONLine_ShoppingContext db;
        public ProductController(ONLine_ShoppingContext _db)
        {
            db = _db;
        }
        [HttpGet]
        [Route("GetAllproduct")]
        public IEnumerable<Product> Allproduct()
       
        {
             return db.Products.ToList();
            
        }
        [HttpPost("AddProduct")]
       
        public IActionResult postProduct([FromBody] ProductViewModel product)
        {
          
           
            Product it = new Product();


            it.PName = product.PName;
            it.PPrize = product.PPrize;
            it.PColor = product.PColor;
            it.PType = product.PType;
            it.PSize = product.PSize;

           
            db.SaveChanges();
            return Ok("Product aadded successfully");
        }


        [HttpGet]
        [Route("SearchProductByName")]
        public IActionResult GetProductByName(string pName)
        {
            var data = db.Products.FirstOrDefault(x => x.PName == pName);
            if (data == null)
            {
                return BadRequest("Record not found.");


            }
            return Ok(data);

            
        }
        [HttpPut]
        [Route("ProductUpdateById")]
        public IActionResult UpdateProductbyId(int id,Product product)
        {
            if (db.Products.Any(x => x.PId == id))
            {
                var data = db.Products.Where(x => x.PId == id).FirstOrDefault();
                data.PName = product.PName;
                data.PPrize = product.PPrize;
                data.PSize = product.PSize;
                data.PType = product.PType;
                data.PColor = product.PColor;

                db.SaveChanges();
                return Ok("Product have been successfully Updated.");
            }
            return BadRequest("Record not found.");
        }
        [HttpDelete]
        [Route("ProductDeleteById")]
        public IActionResult DeleteProductById(int id)
        {
            if (db.Products.Any(x => x.PId == id))
            {
                var data = db.Products.Where(x => x.PId == id).FirstOrDefault();
                db.Products.Remove(data);
                db.SaveChanges();
                return Ok("Product have been successfully Deleted.");
            }
            return BadRequest("Record not found.");
        }
    }
}
