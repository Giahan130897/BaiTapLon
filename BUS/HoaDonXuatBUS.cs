using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class HoaDonXuatBUS
    {
        HoaDonXuatDAO hdxDAO = new HoaDonXuatDAO();

        public List<object> getAll()
        {
            return (hdxDAO.getAll());

        }

      

    }
}
