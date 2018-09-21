using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using WebApplication.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductsRepository productsRepository = new ProductsRepository();
        // GET: api/products
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return productsRepository.GetAllProducts();
        }
    }
}
