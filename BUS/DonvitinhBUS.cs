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
   public class DonvitinhBUS
    {
        DonvitinhDAO DonvitinhDAO = new DonvitinhDAO();
        public DataTable GetTable()
        {
            try
            {
                return DonvitinhDAO.GetTable();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
