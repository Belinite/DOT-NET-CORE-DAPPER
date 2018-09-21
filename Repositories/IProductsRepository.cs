using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Store.Models;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace WebApplication.Repositories
{
    public interface IProductsRepository
    {
        IEnumerable<Products> GetAllProducts();
    }
    public class ProductsRepository:IProductsRepository
    {
        private readonly string _connectionString = "Data Source=Server;Initial Catalog = store; User ID = User; Password=Password";
        public IEnumerable<Products> GetAllProducts()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                
                return db.Query<Products>("SELECT * FROM Products").ToList();
               
            }
        }
    }
}