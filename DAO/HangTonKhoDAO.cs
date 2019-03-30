using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class HangTonKhoDAO : DataProvider
    {

        private List<object> getData(SqlDataReader reader)
        {
            List<object> list = new List<object>();
            int _MAHANG;
            string _BARCODE, _TENHANG, _TENNHACUNGCAP, _TENDONVITINH, _TENLOAIHANG;
            int _SOLUONG;
            Int64 _TOTAL_SL_GB,_TOTAL_SL_GN;
            Int64 _TIENLOI;
            Int64 _GIANHAP, _GIABAN;
            DateTime _NGAYCAPNHAT;
            while (reader.Read())
            {
                _MAHANG = reader.GetInt32(0);
                _BARCODE = getDataReader(reader, 1);
                _TENHANG = getDataReader(reader, 2);
                _TENNHACUNGCAP = getDataReader(reader, 3);
                _TENDONVITINH = getDataReader(reader, 4);
                _TENLOAIHANG = getDataReader(reader, 5);
                _SOLUONG = reader.GetInt32(6);
                _GIANHAP = reader.GetInt64(7);
                _TIENLOI = reader.GetInt64(8);
                _GIABAN = reader.GetInt64(9);
                _NGAYCAPNHAT = reader.GetDateTime(10);
                _TOTAL_SL_GB = reader.GetInt64(11);
                _TOTAL_SL_GN = reader.GetInt64(12);

                var emp = new
                {
                    MAHANG = _MAHANG,
                    BARCODE = _BARCODE,
                    TENHANG = _TENHANG,
                    TENNHACUNGCAP = _TENNHACUNGCAP,
                    TENDONVITINH = _TENDONVITINH,
                    TENLOAIHANG = _TENLOAIHANG,
                    SOLUONG = _SOLUONG,
                    GIANHAP = _GIANHAP,
                    TIENLOI = _TIENLOI,
                    GIABAN = _GIABAN,
                    NGAYCAPNHAT = _NGAYCAPNHAT,
                    TOTAL_SL_GB = _TOTAL_SL_GB,
                    TOTAL_SL_GN = _TOTAL_SL_GN
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
                cmd.CommandText = "MATHANG_GetAllHangTonKho";
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

        public List<object> search(string SEARCHDATA)
        {
            Connect();
            List<object> list = new List<object>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;
                cmd.CommandText = "MATHANG_SearchHangTonKho";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@SEARCHDATA", SEARCHDATA);
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

        public int update(int MAHANG, int SOLUONG, Int64 GIANHAP, Int64 GIABAN, DateTime NGAYCAPNHAT)
        {
            Connect();
            List<object> list = new List<object>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "MATHANG_HANGTONKHO_UPDATE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@MAHANG", MAHANG);
                cmd.Parameters.AddWithValue("@SOLUONG", SOLUONG);
                cmd.Parameters.AddWithValue("@GIANHAP", GIANHAP);
                cmd.Parameters.AddWithValue("@GIABAN", GIABAN);
                cmd.Parameters.AddWithValue("@NGAYCAPNHAT", NGAYCAPNHAT);
                int numberOfRows = cmd.ExecuteNonQuery();
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
