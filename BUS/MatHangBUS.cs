using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class MatHangBUS
    {
        MatHangDAO mtDAO = new MatHangDAO();

        public List<object> getAll()
        {
            return (mtDAO.getAll());
          
        }

        public List<object> searchByTenHang(string tenhang)
        {
            return (mtDAO.searchByTenHang(tenhang));

        }

        public List<object> searchByMaHang(int mahang)
        {
            return (mtDAO.searchByMaHang(mahang));
        }

        public List<object> searchByBarcode(string search)
        {
            return (mtDAO.searchByBarcode(search));
        }
        public int Delete(int ID)
        {
            return mtDAO.Delete(ID);
        }
    }
}
