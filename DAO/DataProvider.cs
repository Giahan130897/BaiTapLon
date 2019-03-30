using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAO
{
    public class DataProvider
    {
       public SqlConnection cn;

        public DataProvider()
        {
            string cnStr = ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;
            cn = new SqlConnection(cnStr);
        }
        public void Connect()
        {
            try
            {
                if (cn != null & cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }
        }
        public void DisConnect()
        {
            if (cn != null & cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Close();
            }
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                return (cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int myExecuteNoneQuery(string sql, CommandType type, List<SqlParameter> parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);

                }
            }
            Connect();

            try
            {
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
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                return cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public string getDataReader(SqlDataReader reader, int indexCol)
        {
            return !reader.IsDBNull(indexCol) ? reader.GetString(indexCol) : null;
        }
        public DataTable GetTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            try
            {
                int numberOfRowss = da.Fill(dt);
                if (numberOfRowss > 0)
                    return dt;
                else
                    return null;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
