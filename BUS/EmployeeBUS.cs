using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class EmployeeBUS
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();

        public List<object> GetData(string sql)
        {
            return (employeeDAO.GetData(sql));
          
        }
       

    }
}
