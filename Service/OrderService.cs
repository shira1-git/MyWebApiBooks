using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
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

        public OrderService(IOrderRepository orderRepository, ShopDb325338135Context shopDbContext)
        {
            this.orderRepository = orderRepository;
            this.shopDbContext = shopDbContext;
        }

        public async Task<Order> Post(Order order)
        {
            Product product;
            double sum = 0;
            foreach (var item in order.OrderItems)
            {
                product = await shopDbContext.Products.FirstOrDefaultAsync(p => p.ProductId == item.ProductId);
                sum = (double)(sum +product.Price);
            }
            if (sum != order.OrderSum)
            {
                throw new Exception($"trying to steal {order.UserId}");
            }

            

            Order newOrder=await orderRepository.Post(order);
            return newOrder;
        }
    }
}
