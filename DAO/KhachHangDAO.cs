using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
   public class KhachHangDAO :DataProvider
    {
        private List<object> getData(SqlDataReader reader)
        {
            string sql = "SELECT * FROM KHACHHANG";
            List<object> list = new List<object>();
            int _MAKHACHHANG;
            string _TENKHACHHANG, _DIACHI, _EMAIL,_FAX;
            int _DIENTHOAI;
            try
            {
                Connect();
                SqlDataReader dr = myExecuteReader(sql);
                while (reader.Read())
                {
                    _MAKHACHHANG = reader.GetInt32(0);
                    _TENKHACHHANG = getDataReader(reader, 1);
                    _DIACHI = getDataReader(reader, 2);
                    _EMAIL = getDataReader(reader, 3);
                    _FAX = getDataReader(reader, 4);
                    _DIENTHOAI = reader.GetInt32(5);


                    var emp = new
                    {
                        MAKHACHHANG = _MAKHACHHANG,
                        TENKHACHHANG = _TENKHACHHANG,
                        DIACHI = _DIACHI,
                        MAIL = _EMAIL,
                        FAX = _FAX,
                        DIENTHOAI = _DIENTHOAI,

                    };
                    list.Add(emp);
                }
                reader.Close();
                return list;
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        private SqlDataReader myExecuteReader(string sql)
        {
            throw new NotImplementedException();
        }

        public List<object> getAll()
        {
            Connect();
            List<object> list = new List<object>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "KHACHHANG_GetALL";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                reader = cmd.ExecuteReader();

                list = getData(reader);

                reader.Close();
                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }

        }

        public DataTable GetTable()
        {
            string sql = "SELECT * FROM KHACHHANG";
            try
            {
                return GetTable(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(KhachHangDTO KhachHangDTO)
        {

            string sql = "INSERT INTO KHACHHANG VALUES("/*@makhachhang,*/+"@tenkhachhang,@diachi,@email,@dienthoai,@fax)";
            List<SqlParameter> parameters = new List<SqlParameter>();
           // parameters.Add(new SqlParameter("@makhachhang", KhachHangDTO.MAKHACHHANG));
            parameters.Add(new SqlParameter("@tenkhachhang", KhachHangDTO.TENKHACHHANG));
            parameters.Add(new SqlParameter("@diachi", KhachHangDTO.DIACHI));
            parameters.Add(new SqlParameter("@email", KhachHangDTO.EMAIL));
            parameters.Add(new SqlParameter("@dienthoai", KhachHangDTO.DIENTHOAI));
            parameters.Add(new SqlParameter("@fax", KhachHangDTO.FAX));


            try
            {
                return (myExecuteNoneQuery(sql, CommandType.Text, parameters));
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }

        public int Delete(int MAKHACHHANG)
        {
            try
            {
                Connect();
                string sql = " DELETE FROM KHACHHANG WHERE MAKHACHHANG = " + MAKHACHHANG.ToString();
                int numberOfRows = ExecuteNonQuery(sql);
                return numberOfRows;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
                    

        }

    }
}
