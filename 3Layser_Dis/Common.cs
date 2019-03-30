using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBH
{
    class Common
    {
        
    }

    public static class MATHANG
    {
        public static void setData(object obj)
        {
            MAHANG = Convert.ToInt32(obj.GetType().GetProperty("MAHANG").GetValue(obj, null));
            BARCODE = Convert.ToString(obj.GetType().GetProperty("BARCODE").GetValue(obj, null));
            TENHANG = Convert.ToString(obj.GetType().GetProperty("TENHANG").GetValue(obj, null));
            TENHANGKHONGDAU = Convert.ToString(obj.GetType().GetProperty("TENHANGKHONGDAU").GetValue(obj, null));
            MANHACUNGCAP = Convert.ToInt32(obj.GetType().GetProperty("MANHACUNGCAP").GetValue(obj, null));
            MALOAIHANG = Convert.ToInt32(obj.GetType().GetProperty("MALOAIHANG").GetValue(obj, null));
            MADONVITINH = Convert.ToInt32(obj.GetType().GetProperty("MADONVITINH").GetValue(obj, null));
            SOLUONG = Convert.ToInt32(obj.GetType().GetProperty("SOLUONG").GetValue(obj, null));
            GIANHAP = Convert.ToInt64(obj.GetType().GetProperty("GIANHAP").GetValue(obj, null));
            GIABAN = Convert.ToInt64(obj.GetType().GetProperty("GIABAN").GetValue(obj, null));
            NGAYCAPNHAT = Convert.ToDateTime(obj.GetType().GetProperty("NGAYCAPNHAT").GetValue(obj, null));
        }
        public static int MAHANG { get; set; }
        public static string BARCODE { get; set; }
        public static string TENHANG { get; set; }
        public static string TENHANGKHONGDAU { get; set; }
        public static int MANHACUNGCAP { get; set; }
        public static int MALOAIHANG { get; set; }
        public static int MADONVITINH { get; set; }
        public static int SOLUONG { get; set; }
        public static Int64 GIANHAP { get; set; }
        public static Int64 GIABAN { get; set; }
        public static DateTime NGAYCAPNHAT { get; set; }
    }

    public static class DONVITINH
    {
        public static int MADONVITINH { get; set; }
        public static string TENDONVITINH { get; set; }
    }

    public static class LOAIHANG
    {
        public static int MALOAIHANG { get; set; }
        public static string TENLOAIHANG { get; set; }
    }

    public static class NHACUNGCAP
    {
        public static int MANHACUNGCAP { get; set; }
        public static string TENNHACUNGCAP { get; set; }
        public static string DIACHI { get; set; }
        public static string EMAIL { get; set; }
        public static string DIENTHOAI { get; set; }
        public static string FAX { get; set; }
    }

    public static class KHACHHANG
    {
        public static int MAKHACHHANG { get; set; }
        public static string TENKHACHHANG { get; set; }
        public static string DIACHI { get; set; }
        public static string EMAIL { get; set; }
        public static string DIENTHOAI { get; set; }
        public static string FAX { get; set; }
    }

    public static class NHANVIEN
    {
        public static void setData(object obj)
        {
            ID = Convert.ToInt32(obj.GetType().GetProperty("ID").GetValue(obj, null));
            TENDN = Convert.ToString(obj.GetType().GetProperty("TENDN").GetValue(obj, null));
            HOTEN = Convert.ToString(obj.GetType().GetProperty("HOTEN").GetValue(obj, null));
            MATKHAU = Convert.ToString(obj.GetType().GetProperty("MATKHAU").GetValue(obj, null));
            DIENTHOAI = Convert.ToString(obj.GetType().GetProperty("DIENTHOAI").GetValue(obj, null));
            CHUCVU = Convert.ToInt32(obj.GetType().GetProperty("CHUCVU").GetValue(obj, null));
            TRANGTHAI = Convert.ToInt32(obj.GetType().GetProperty("TRANGTHAI").GetValue(obj, null));
            NGAYTAO = Convert.ToDateTime(obj.GetType().GetProperty("NGAYTAO").GetValue(obj, null));
            NGAYCAPNHAT = Convert.ToDateTime(obj.GetType().GetProperty("NGAYCAPNHAT").GetValue(obj, null));
        }
        public static int ID { get; set; }
        public static string TENDN { get; set; }
        public static string HOTEN { get; set; }
        public static string MATKHAU { get; set; }
        public static string DIENTHOAI { get; set; }
        public static int CHUCVU { get; set; }
        public static int TRANGTHAI { get; set; }
        public static DateTime NGAYTAO { get; set; }
        public static DateTime NGAYCAPNHAT { get; set; }

    }

    public static class HANGTONKHO
    {
        public static void setData(object obj)
        {
            MAHANG = Convert.ToInt32(obj.GetType().GetProperty("MAHANG").GetValue(obj, null));
            SOLUONG = Convert.ToInt32(obj.GetType().GetProperty("SOLUONG").GetValue(obj, null));
            GIANHAP = Convert.ToInt64(obj.GetType().GetProperty("GIANHAP").GetValue(obj, null));
            GIABAN = Convert.ToInt64(obj.GetType().GetProperty("GIABAN").GetValue(obj, null));
            TOTAL_SL_GB = Convert.ToInt64(obj.GetType().GetProperty("TOTAL_SL_GB").GetValue(obj, null));
            TOTAL_SL_GN = Convert.ToInt64(obj.GetType().GetProperty("TOTAL_SL_GN").GetValue(obj, null));
            NGAYCAPNHAT = Convert.ToDateTime(obj.GetType().GetProperty("NGAYCAPNHAT").GetValue(obj, null));
            TENHANG = Convert.ToString(obj.GetType().GetProperty("TENHANG").GetValue(obj, null));
            TENNHACUNGCAP = Convert.ToString(obj.GetType().GetProperty("TENNHACUNGCAP").GetValue(obj, null));
            TENDONVITINH = Convert.ToString(obj.GetType().GetProperty("TENDONVITINH").GetValue(obj, null));
            TENLOAIHANG = Convert.ToString(obj.GetType().GetProperty("TENLOAIHANG").GetValue(obj, null));
            TIENLOI = GIABAN - GIANHAP;
        }

        public static int MAHANG { get; set; }
        public static string BARCODE { get; set; }
        public static string TENHANG { get; set; }
        public static string TENNHACUNGCAP { get; set; }
        public static string TENDONVITINH { get; set; }
        public static string TENLOAIHANG { get; set; }
        public static int SOLUONG { get; set; }
        public static Int64 GIANHAP { get; set; }
        public static Int64 TIENLOI { get; set; }
        public static Int64 GIABAN { get; set; }
        public static DateTime NGAYCAPNHAT { get; set; }
        public static Int64 TOTAL_SL_GB { get; set; }
        public static Int64 TOTAL_SL_GN { get; set; }
    }
}
