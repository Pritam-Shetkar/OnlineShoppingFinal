using Microsoft.AspNetCore.Mvc;
using Shopping.Models;
using Shopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    public class OrderController : Controller
    {
        ONLine_ShoppingContext db;
        public OrderController(ONLine_ShoppingContext _db)
        {
            db = _db;
        }

        [HttpPost("OrderAdd")]
        public IActionResult AddOreder(OrderViewModel orderPlaced )
        {
            Random random = new Random();
            int uid = random.Next(10000, 99999);
            string orderId = "OD" + uid;
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.CId = orderPlaced.CId;
            orderDetail.PId = orderPlaced.PId;
            orderDetail.OrderDate = orderPlaced.OrderDate;
            orderDetail.OrderId = orderId.ToString();
            db.OrderDetails.Add(orderDetail);
            db.SaveChanges();

            return Ok("Order Added SuccessFully");
        }
    }
}
