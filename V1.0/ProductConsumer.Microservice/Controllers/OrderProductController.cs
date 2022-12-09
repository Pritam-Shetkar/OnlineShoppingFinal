using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProductController : Controller
    {

        private readonly IBus bus;
        public OrderProductController(IBus _bus)
        {
            bus = _bus;
        }

        [HttpPost]
        public async Task<IActionResult> OrderProduct(ProductDetails product)
        {
            if (product != null)
            {
                product.BookedOn = DateTime.Now;
                Uri uri = new Uri("rabbitmq://localhost/orderQueue");
                var endpoint = await bus.GetSendEndpoint(uri);
                await endpoint.Send(product);
                return Ok();
            }
            return BadRequest();
        }

      
    }
}
