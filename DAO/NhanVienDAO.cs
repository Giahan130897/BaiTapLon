using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class NhanVienDAO : DataProvider
    {

        private List<object> getData(SqlDataReader reader)
        {
            List<object> list = new List<object>();
            int _ID;
            string _TENDN, _MATKHAU;
            string _HOTEN, _DIENTHOAI, _DIACHI;
            int _CHUCVU, _TRANGTHAI;
            DateTime _NGAYTAO, _NGAYCAPNHAT;
            while (reader.Read())
            {
                _ID = reader.GetInt32(0);
                _TENDN = getDataReader(reader, 1);
                _MATKHAU = getDataReader(reader, 2);
                _HOTEN = getDataReader(reader, 3);
                _DIENTHOAI = getDataReader(reader, 4);
                _DIACHI = getDataReader(reader, 5);
                _CHUCVU = reader.GetInt32(6);
                _TRANGTHAI = reader.GetInt32(7);
                _NGAYTAO = reader.GetDateTime(8);
                _NGAYCAPNHAT = reader.GetDateTime(9);

                var emp = new
                {
                    ID = _ID,
                    TENDN = _TENDN,
                    MATKHAU = _MATKHAU,
                    HOTEN = _HOTEN,
                    DIENTHOAI = _DIENTHOAI,
                    DIACHI = _DIACHI,
                    CHUCVU = _CHUCVU,
                    TRANGTHAI = _TRANGTHAI,
                    NGAYTAO = _NGAYTAO,
                    NGAYCAPNHAT = _NGAYCAPNHAT
                };
                list.Add(emp);
            }
            reader.Close();
            return list;
        }

        public List<object> Login(string TENDN, string MATKHAU)
        {
            Connect();
            List<object> list = new List<object>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "NHANVIEN_Login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@TENDN", TENDN);
                cmd.Parameters.AddWithValue("@MATKHAU", MATKHAU);
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
       
        
    }
}
