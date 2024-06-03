using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
<<<<<<< HEAD
using Microsoft.Extensions.Logging;
=======
>>>>>>> a3847faecf94dcd15fa9e2a2541b09d81fefac35
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : IOrderService
    {
        ShopDb325338135Context shopDbContext;
        private IOrderRepository orderRepository;
<<<<<<< HEAD
        private ILogger<OrderService> logger;

        public OrderService(IOrderRepository orderRepository, ShopDb325338135Context shopDbContext, ILogger<OrderService> logger)
        {
            this.orderRepository = orderRepository;
            this.shopDbContext = shopDbContext;
            this.logger = logger;
=======

        public OrderService(IOrderRepository orderRepository, ShopDb325338135Context shopDbContext)
        {
            this.orderRepository = orderRepository;
            this.shopDbContext = shopDbContext;
>>>>>>> a3847faecf94dcd15fa9e2a2541b09d81fefac35
        }

        public async Task<Order> Post(Order order)
        {
            Product product;
            double sum = 0;
            foreach (var item in order.OrderItems)
            {
                product = await shopDbContext.Products.FirstOrDefaultAsync(p => p.ProductId == item.ProductId);
<<<<<<< HEAD
                sum = (double)(sum +product.Price*item.Quentity);
            }
            if (sum != order.OrderSum)
            {
                logger.LogError($"trying to steal {order.UserId}");
                return null;
            }

=======
                sum = (double)(sum +product.Price);
            }
            if (sum != order.OrderSum)
            {
                throw new Exception($"trying to steal {order.UserId}");
            }

            

>>>>>>> a3847faecf94dcd15fa9e2a2541b09d81fefac35
            Order newOrder=await orderRepository.Post(order);
            return newOrder;
        }
    }
}
