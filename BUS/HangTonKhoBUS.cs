using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class HangTonKhoBUS
    {
        HangTonKhoDAO mtDAO = new HangTonKhoDAO();

        public List<object> getAll()
        {
            return (mtDAO.getAll());
          
        }

        public List<object> search(string searchdata)
        {
            return (mtDAO.search(searchdata));

        }

        public int update(int MAHANG, int SOLUONG, Int64 GIANHAP, Int64 GIABAN, DateTime NGAYCAPNHAT)
        {
            return mtDAO.update(MAHANG, SOLUONG, GIANHAP, GIABAN, NGAYCAPNHAT);
        }

    }
}
