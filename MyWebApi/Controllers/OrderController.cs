﻿using AutoMapper;
using DTO;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Zxcvbn;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService orderService;
        private IMapper mapper;

        public OrderController(IOrderService orderService,IMapper mapper)
        {
            this.orderService = orderService;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return null;
            //return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Post([FromBody] OrderDTO order)
        {
            var orderDto = mapper.Map<OrderDTO, Order>(order);

            Order o = await orderService.Post(orderDto);
            //var oo = mapper.Map<Order, OrderAfterDTO >(o);
            if (o != null)
                return CreatedAtAction(nameof(Get), new { id = o.OrderId });
            return NoContent();
        }

    }
}
