using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
  public class DonvitinhDAO:DataProvider
    {
        public DataTable GetTable()
        {
            string sql = "SELECT * FROM DONVITINH";
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
