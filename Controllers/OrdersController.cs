using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Repositories;
using Store.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepository ordersRepository = new OrdersRepository();
        // GET: api/orders/1
        [HttpGet("{id}")]
        public Orders Get(int id)
        {
            return ordersRepository.Get(id);
        }
    }
}