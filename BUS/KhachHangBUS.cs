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
    
    public class KhachHangBUS
    {

        KhachHangDAO khDAO = new KhachHangDAO();
        KhachHangDAO khachhangDAO = new KhachHangDAO();
        public DataTable GetTable()
        {
            try
            {
                return khachhangDAO.GetTable();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(KhachHangDTO KhachHangDTO)
        {
            try
            {
                return khachhangDAO.Add(KhachHangDTO);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(int makhachhang)
        {
            return khDAO.Delete(makhachhang);
        }


        public static object GetData(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
