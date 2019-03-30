using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
   public class LoaihangDAO : DataProvider
    {
        public DataTable GetTable()
        {
            string sql = "SELECT * FROM LOAIHANG";
            try
            {
                return GetTable(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
