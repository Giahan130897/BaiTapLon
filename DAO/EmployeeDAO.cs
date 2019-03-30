using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAO
{
        public class EmployeeDAO : DataProvider
        {
            public List<object> GetData(string sql)
            {
                Connect();
                List<object> list = new List<object>();
                //string sql = "SELECT * FROM Nhanvien";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    int id;
                    string lastname, firstname;
                    string address;
                    string phone;
                    while (dr.Read())
                    {
                        id = dr.GetInt32(0);
                        lastname = dr.GetString(1);
                        firstname = dr.GetString(2);
                        address = dr.GetString(3);
                        phone = dr.GetString(4);

                        var emp = new { Ma = id, Ho = lastname, Ten = firstname, Diachi = address , SDT
                         = phone};
                        list.Add(emp);
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
            
        }
    }

