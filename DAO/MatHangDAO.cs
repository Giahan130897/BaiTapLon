using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class MatHangDAO : DataProvider
    {

        private List<object> getData(SqlDataReader reader)
        {
            List<object> list = new List<object>();
            int _MAHANG;
            string _BARCODE, _TENHANG, _TENHANGKHONGDAU;
            int _MANHACUNGCAP, _MALOAIHANG, _MADONVITINH, _SOLUONG;
            Int64 _GIANHAP, _GIABAN;
            DateTime _NGAYCAPNHAT;
            while (reader.Read())
            {
                _MAHANG = reader.GetInt32(0);
                _BARCODE = getDataReader(reader, 1);
                _TENHANG = getDataReader(reader, 2);
                _TENHANGKHONGDAU = getDataReader(reader, 3);
                _MANHACUNGCAP = reader.GetInt32(4);
                _MALOAIHANG = reader.GetInt32(5);
                _MADONVITINH = reader.GetInt32(6);
                _SOLUONG = reader.GetInt32(7);
                _GIANHAP = reader.GetInt64(8);
                _GIABAN = reader.GetInt64(9);
                _NGAYCAPNHAT = reader.GetDateTime(10);

                var emp = new
                {
                    MAHANG = _MAHANG,
                    BARCODE = _BARCODE,
                    TENHANG = _TENHANG,
                    TENHANGKHONGDAU = _TENHANGKHONGDAU,
                    MANHACUNGCAP = _MANHACUNGCAP,
                    MALOAIHANG = _MALOAIHANG,
                    MADONVITINH = _MADONVITINH,
                    SOLUONG = _SOLUONG,
                    GIANHAP = _GIANHAP,
                    GIABAN = _GIABAN,
                    NGAYCAPNHAT = _NGAYCAPNHAT
                };
                list.Add(emp);
            }
            reader.Close();
            return list;
        }

        public List<object> getAll()
        {
            Connect();
            List<object> list = new List<object>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "MATHANG_GetALL";
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

        public List<object> searchByMaHang(int mahang)
        {
            Connect();
            List<object> list = new List<object>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "MATHANG_GetByMAHANG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@MAHANG", mahang);
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

        public List<object> searchByBarcode(string barcode)
        {
            Connect();
            List<object> list = new List<object>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "MATHANG_GetByBARCODE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@BARCODE", barcode);
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

        public List<object> searchByTenHang(string tenhang)
        {
            Connect();
            List<object> list = new List<object>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "MATHANG_SearchTENHANGKHONGDAU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@TENHANGKHONGDAU", tenhang);
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
        public int Delete(int MAHANG)
        {
            try
            {
                Connect();
                string sql = " DELETE FROM MATHANG WHERE MAHANG = " + MAHANG.ToString();
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
