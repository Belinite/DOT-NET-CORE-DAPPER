using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Store.Models;
using Dapper;

namespace WebApplication.Repositories
{
    public interface IOrdersRepository
    {
         Orders Get(int GoodId);
    }
    public class OrdersRepository: IOrdersRepository
    {
        private readonly string _connectionString = "Data Source=Server;Initial Catalog = store; User ID = User; Password=Password";
        //"Server=(localdb)/SQLEXPRESS;Database = store; Trusted_Connection=True;";
        public Orders Get(int id)
        {
            Orders order = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                order = db.Query<Orders>("SELECT * FROM Orders WHERE Id = @id", new { id }).FirstOrDefault();
               
            }
           return order;
        }
    }
}
