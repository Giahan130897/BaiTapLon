using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
  public class NhacungcapBUS
    {
      nhacungcapDAO NhacungcapDAO = new nhacungcapDAO();
        public DataTable GetTable()
        {
            try
            {
                return NhacungcapDAO.GetTable();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(NhacungcapDTO NhacungcapDTO)
        {
            try
            {
                return NhacungcapDAO.Add(NhacungcapDTO); ;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
       
       
    }
}
