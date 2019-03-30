using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
         public class Product
    {
             

        public string  mahang { get; set; }
             public string  barcode { get; set; }
             public string  tenhang { get; set; }
             public string  tenhangkhongdau { get; set; }
             public string  manhacungcap { get; set; }
             public string  maloaihang { get; set; }
             public string  madonvitinh { get; set; }
             public int  soluong { get; set; }
             public int  gianhap { get; set; }
             public int  giaban { get; set; }
             public string  ngaycapnhap { get; set; }

        public Product(string MAHANG, string BARCODE,string TENHANG,string TENHANGKHONGDAU ,string MANHACUNGCAP,string MALOAIHANG,string MADONVITINH,
            int SOLUONG,int GIANHAP,int GIABAN,string NGAYCAPNHAP ) 
        {
            mahang = MAHANG;
            barcode = BARCODE;
            tenhang = TENHANG;
            tenhangkhongdau = TENHANGKHONGDAU;
            manhacungcap = MANHACUNGCAP;
            maloaihang = MALOAIHANG;
            madonvitinh = MADONVITINH;
            soluong = SOLUONG;
            gianhap = GIANHAP;
              giaban = GIABAN;
              ngaycapnhap = NGAYCAPNHAP;


        }
        public Product(string id, string name)
        {

            
        }
    }
}
