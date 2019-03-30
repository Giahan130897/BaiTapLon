using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class LoaihangDTO
    {
         public int  MALOAIHANG { get; set; }
        public string TENLOAIHANG { get; set; }


        public LoaihangDTO(int maloaihang, string tenloaihang) 
        {
            MALOAIHANG = maloaihang;
            TENLOAIHANG = tenloaihang;
           
        }
    }
}
