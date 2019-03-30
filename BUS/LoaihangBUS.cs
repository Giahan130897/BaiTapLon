using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class LoaihangBUS
    {
        LoaihangDAO LoaihangDAO = new LoaihangDAO();
        public DataTable GetTable()
        {
            try
            {
                return LoaihangDAO.GetTable();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
