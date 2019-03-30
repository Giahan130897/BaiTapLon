using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data.SqlClient;

using DTO;
namespace BUS
{
    public class ProductBus
    {
        ProductDao productDao = new ProductDao();

        public List<object> GetData(string sql)
        {
            return (productDao.GetData(sql));

        }
        public int Add(Product product)
        {
            try
            {
                return productDao.addiit(product);
            }
            catch (SqlException ex )
            {
                throw ex ;
            }
        }

    }
}
