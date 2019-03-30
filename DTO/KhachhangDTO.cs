using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHangDTO
    {
       // public int  MAKHACHHANG { get; set; }
        public string TENKHACHHANG { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }
        public string DIENTHOAI { get; set; }
        public string FAX { get; set; }

        public KhachHangDTO(/*int makhachhang,*/ string tenkhachhang, string diachi, string email, string dienthoai, string fax) 
        {
            //MAKHACHHANG = makhachhang;
            TENKHACHHANG = tenkhachhang;
            DIACHI = diachi;
            EMAIL = email;
            DIENTHOAI = dienthoai;
            FAX = fax;
        }
    }
}
