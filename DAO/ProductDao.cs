using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;
namespace DAO
{
    public class ProductDao : DataProvider
    {
        public List<object> GetData(string sql)
        {
            Connect();
            List<object> list = new List<object>();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                string id;
                string name;
                while (dr.Read())
                {
                    id = dr.GetString(0);
                    name = dr.GetString(1);

                    var product = new
                    {
                        MaSP = id,
                        TenSP = name
                    };
                    list.Add(product);
                }
                dr.Close();
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
        public int addiit(Product MAHANG)
        {
            string sql = "INSERT INTO Product VALUES(@mamathang,@barcode,@tenhang,@TENHANGKHONGDAU,@MANHACUNGCAP,@MALOAIHANG,"
            + "@MADONVITINH , @soluong, @gianhap, @giaban, @ngaycapnhat)";
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@mamathang", MAHANG.mahang));
            parameters.Add(new SqlParameter("@barcode", MAHANG.barcode));
            parameters.Add(new SqlParameter("@tenhang", MAHANG.tenhang));
            parameters.Add(new SqlParameter("@TENHANGKHONGDAU", MAHANG.tenhangkhongdau));
            parameters.Add(new SqlParameter("@MANHACUNGCAP", MAHANG.manhacungcap));
            parameters.Add(new SqlParameter("@MALOAIHANG", MAHANG.maloaihang));
            parameters.Add(new SqlParameter("@MADONVITINH", MAHANG.madonvitinh));
            parameters.Add(new SqlParameter("@soluong", MAHANG.soluong));
            parameters.Add(new SqlParameter("@gianhap", MAHANG.gianhap));
            parameters.Add(new SqlParameter("@giaban", MAHANG.giaban));
            parameters.Add(new SqlParameter("@ngaycapnhat", MAHANG.ngaycapnhap));


            return (myExecuteNoneQuery(sql, CommandType.Text, parameters));
        }
    }
}
