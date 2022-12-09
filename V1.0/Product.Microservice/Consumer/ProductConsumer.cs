using MassTransit;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Microservice.Consumer
{
    
    public class ProductConsumer : IConsumer<ProductDetails>
    {
        public async Task Consume(ConsumeContext<ProductDetails> context)
        {
            var data = context.Message;
        }
    }
}
