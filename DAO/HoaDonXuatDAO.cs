using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class HoaDonXuatDAO : DataProvider
    {

        private List<object> getData(SqlDataReader reader)
        {
            List<object> list = new List<object>();
            int _SOHOADON, _MAKHACHHANG;
            DateTime _NGAYDATHANG, _NGAYGIAOHANG;
            string _DIADIEM;
            Int64 _THANHTIEN, _TIENLOI;
            int _MANHANVIEN;
            while (reader.Read())
            {
                _SOHOADON = reader.GetInt32(0);
                _MAKHACHHANG = reader.GetInt32(1);
                _NGAYDATHANG = reader.GetDateTime(2);
                _NGAYGIAOHANG = reader.GetDateTime(3);
                _DIADIEM = getDataReader(reader, 4);
                _THANHTIEN = reader.GetInt64(5);
                _TIENLOI = reader.GetInt64(6);
                _MANHANVIEN = reader.GetInt32(7);

                var emp = new
                {
                    SOHOADON = _SOHOADON,
                    MAKHACHHANG = _MAKHACHHANG,
                    NGAYDATHANG = _NGAYDATHANG,
                    NGAYGIAOHANG = _NGAYGIAOHANG,
                    DIADIEM = _DIADIEM,
                    THANHTIEN = _THANHTIEN,
                    TIENLOI = _TIENLOI,
                    MANHANVIEN = _MANHANVIEN
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
                cmd.CommandText = "HOADONXUAT_GetALL";
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
        
        
    }
}
