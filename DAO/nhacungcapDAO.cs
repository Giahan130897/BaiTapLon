using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class nhacungcapDAO:DataProvider
    {
        public DataTable GetTable()
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            try
            {
                return GetTable(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(NhacungcapDTO NhacungcapDTO)
        {

            string sql = "INSERT INTO NHACUNGCAP VALUES(@tennhacungcap,@diachi,@email,@dienthoai,@fax)";
            List<SqlParameter> parameters = new List<SqlParameter>();
           // parameters.Add(new SqlParameter("@manhacungcap", NhacungcapDTO.MANHACUNGCAP));
            parameters.Add(new SqlParameter("@tennhacungcap", NhacungcapDTO.TENNHACUNGCAP));
            parameters.Add(new SqlParameter("@diachi", NhacungcapDTO.DIACHI));
            parameters.Add(new SqlParameter("@email", NhacungcapDTO.EMAIL));
            parameters.Add(new SqlParameter("@dienthoai", NhacungcapDTO.DIENTHOAI));
            parameters.Add(new SqlParameter("@fax", NhacungcapDTO.FAX));


            try
            {
                return (myExecuteNoneQuery(sql, CommandType.Text, parameters));
            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }
        


       
    }
}
