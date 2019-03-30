using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvDAO = new NhanVienDAO();

        public List<object> Login(string TENDN, string MATKHAU)
        {
            return (nvDAO.Login(TENDN, MATKHAU));
          
        }
        

    }
}
