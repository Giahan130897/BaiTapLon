using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhacungcapDTO
    {
        //public int  MANHACUNGCAP { get; set; }
        public string TENNHACUNGCAP { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }
        public string DIENTHOAI { get; set; }
        public string FAX { get; set; }

        public NhacungcapDTO( string tennhacungcap, string diachi, string email, string dienthoai, string fax) 
        {
           // MANHACUNGCAP = manhacungcap;
            TENNHACUNGCAP = tennhacungcap;
            DIACHI = diachi;
            EMAIL = email;
            DIENTHOAI = dienthoai;
            FAX = fax;
        }
    }
}
