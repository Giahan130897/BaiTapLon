using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DonViTinhDTO
    {
       // public int  MADONVITINH { get; set; }
        public string TENDONVITINH { get; set; }
       

        public DonViTinhDTO( string tendonvitinh) 
        {
           // MADONVITINH = madonvitinh;
            TENDONVITINH = tendonvitinh;
           
        }
    }
}
