using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.SqlClient;
namespace QLBH
{
    public partial class FormMain : Form
    {
         ProductBus productBUS = new ProductBus();
     
        //Using for Updating and Deleting
        //Set ID when click cell dgv
        int dgv_mamathang = 0;
        int _MANHANVIEN = 0, _CHUCVU = 0;
        int rowNum_banhang_main = 0;

        List<object> dsBanHang = new List<object>();
        //bool dgv_mamathang_sort = false, dgv_mamathang_main_sort = false, dgv_mamathang_hoadon_sort = false, dgv_makhachhang_sort = false, dgv_maloaihang_sort = false, dgv_madonvitinh_sort = false, dgv_manhacungcap_sort = false;

        DataTable _dtBanHangMain;
        DataTable _dtBanHangMatHang;
        DataTable _dtBanHangHoaDon;
        DataTable _dtHangTonKho;

        public FormMain()
        {
            InitializeComponent();
            _dtBanHangMain = getStructBanHangMain("BanHangMain");
            _dtBanHangMatHang = getStructBanHangMain("BanHangMatHang");
            _dtBanHangHoaDon = getStructBanHangMain("BanHangHoaDon");
            _dtHangTonKho = getStructHangTonKhoMain("HangTonKho");
        }

        private DataTable getStructBanHangMain(string tableName)
        {
            DataTable dt = new DataTable(tableName);
            DataColumn dc1 = new DataColumn("STT");
            DataColumn dc2 = new DataColumn("Tên Mặt Hàng");
            DataColumn dc3 = new DataColumn("ĐVT");
            DataColumn dc4 = new DataColumn("SL");
            DataColumn dc5 = new DataColumn("Giá Nhập");
            DataColumn dc6 = new DataColumn("Giá Bán");
            DataColumn dc7 = new DataColumn("Thành Tiền");
            DataColumn dc8 = new DataColumn("MAHANG");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            dt.Columns.Add(dc8);
            return dt;
        }

        private DataTable getStructHangTonKhoMain(string tableName)
        {
            DataTable dt = new DataTable(tableName);
            DataColumn dc1 = new DataColumn("STT");
            DataColumn dc2 = new DataColumn("Tên Mặt Hàng");
            DataColumn dc3 = new DataColumn("Tên NCC");
            DataColumn dc4 = new DataColumn("Tên ĐVT");
            DataColumn dc5 = new DataColumn("Tên LH");
            DataColumn dc6 = new DataColumn("SL");
            DataColumn dc7 = new DataColumn("Giá Nhập");
            DataColumn dc8 = new DataColumn("Lợi Nhuận");
            DataColumn dc9 = new DataColumn("Giá Bán");
            DataColumn dc10 = new DataColumn("Tổng GN");
            DataColumn dc11 = new DataColumn("Tổng GB");
            DataColumn dc12 = new DataColumn("Ngày Cập Nhật");
            DataColumn dc13 = new DataColumn("MAHANG");

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            dt.Columns.Add(dc8);
            dt.Columns.Add(dc9);
            dt.Columns.Add(dc10);
            dt.Columns.Add(dc11);
            dt.Columns.Add(dc12);
            dt.Columns.Add(dc13);
            return dt;
        }

        private void Begining()
        {
           // tabControl_qlbh.TabPages.Remove(tp_banhang);
            tabControl_qlbh.TabPages.Remove(tp_mathang);
            tabControl_qlbh.TabPages.Remove(tp_khachhang);
            tabControl_qlbh.TabPages.Remove(tp_nhacungcap);
            tabControl_qlbh.TabPages.Remove(tp_hangtonkho);
            //tabControl_qlbh.TabPages.Remove(tp_thongke);
            //tabControl_qlbh.TabPages.Remove(tp_donvitinh);
            tabControl_qlbh.TabPages.Remove(tp_loaihang);

           // btn_menu_banhang.Visible = false;
            btn_menu_mathang.Visible = false;
            btn_menu_khachhang.Visible = false;
            btn_menu_nhacungcap.Visible = false;
            btn_menu_hangtonkho.Visible = false;
            //btn_menu_thongke.Visible = false;
            //btn_menu_donvitinh.Visible = false;
            btn_menu_loaihang.Visible = false;
            btn_menu_dangxuat.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Begining();
        }

        private void hideAllColumns(ref DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Visible = true;
            }
        }

        private void dgvShowAllColumns(ref DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Visible = false;
            }
        }

        private void dgvReadOnlyAllColumns(ref DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private static void dgvReadOnlyCustomColumns(DataGridView dgv, string[] strs)
        {
            string[] revArray = Array.ConvertAll<string, string>(strs, delegate(string s) { return s.ToLower(); });

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (Array.IndexOf(revArray, column.Name.ToLower()) > -1)
                    column.ReadOnly = false;
                else column.ReadOnly = true;
            }
        }

        private static void dgvShowCustomColumns(DataGridView dgv, string[] strs)
        {
            string[] revArray = Array.ConvertAll<string, string>(strs, delegate(string s) { return s.ToLower(); });

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (Array.IndexOf(revArray, column.Name.ToLower()) > -1)
                    column.Visible = true;
                else column.Visible = false;
            }
        }

        /*private void loadHDX()
        {
            try
            {
                HoaDonXuatBUS bus = new HoaDonXuatBUS();
                List<object> dsmh = bus.getAll();
                dgv_banhang_hoadon.DataSource = dsmh;
                dgvShowCustomColumns(dgv_banhang_hoadon, new string[] { "NGAYDATHANG" });
                dgv_banhang_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { }
        }*/

        private void btn_dangnhap_login_Click(object sender, EventArgs e)
        {
            string tendn = tb_dangnhap_username.Text.Trim();
            string matkhau = tb_dangnhap_password.Text.Trim();

            NhanVienBUS nv = new NhanVienBUS();
            List<object> list = nv.Login(tendn, matkhau);

            if (list.Count == 0)
            {
                MessageBox.Show("Đăng Nhập Thất Bại!\nVui Lòng Thử Lại!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            NHANVIEN.setData(list[0]);
            _MANHANVIEN = NHANVIEN.ID;
            _CHUCVU = NHANVIEN.CHUCVU;

            tabControl_qlbh.TabPages.Remove(tp_dangnhap);

            btn_menu_dangxuat.Visible = true;
            //btn_menu_banhang.Visible = true;
            btn_menu_khachhang.Visible = true;

            if (_CHUCVU == 2)
            {
            }
            else if (_CHUCVU == 1)//Admin
            {
                btn_menu_mathang.Visible = true;
                btn_menu_nhacungcap.Visible = true;
                btn_menu_hangtonkho.Visible = true;
                //btn_menu_thongke.Visible = true;
                //btn_menu_donvitinh.Visible = true;
                btn_menu_loaihang.Visible = true;
            }
            //tabControl_qlbh.TabPages.Add(tp_banhang);
            //loadHDX();
            
        }

        private void btn_menu_dangxuat_Click(object sender, EventArgs e)
        {
            Begining();
            tabControl_qlbh.TabPages.Add(tp_dangnhap);
        }

        private void btn_menu_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn Thoát?", "Thông Tin", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        /*private void btn_menu_banhang_Click(object sender, EventArgs e)
        {
            if (!tabControl_qlbh.TabPages.ContainsKey("tp_banhang"))
            {
                tabControl_qlbh.TabPages.Add(tp_banhang);
            }
            TabPage testPage = tabControl_qlbh.TabPages["tp_banhang"];
            tabControl_qlbh.SelectedTab = testPage;


            loadHDX();
        }*/

        private void loadMatHang()
        {
            try
            {
                MatHangBUS bus = new MatHangBUS();
                List<object> dsmh = bus.getAll();
                dgv_mathang_main.DataSource = dsmh;
                dgvShowCustomColumns(dgv_mathang_main, new string[] { "TENHANG", "SOLUONG", "GIANHAP", "GIABAN" });
                dgv_mathang_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch { }
        }
        


        private void btn_menu_mathang_Click(object sender, EventArgs e)
        {
            if (!tabControl_qlbh.TabPages.ContainsKey("tp_mathang"))
            {
                tabControl_qlbh.TabPages.Add(tp_mathang);
            }
            TabPage testPage = tabControl_qlbh.TabPages["tp_mathang"];
            tabControl_qlbh.SelectedTab = testPage;

            loadMatHang();

        }
        KhachHangBUS khachhangBUS = new KhachHangBUS();

        private void btn_menu_khachhang_Click(object sender, EventArgs e)
        {
            if (!tabControl_qlbh.TabPages.ContainsKey("tp_khachhang"))
            {
                tabControl_qlbh.TabPages.Add(tp_khachhang);
            }
            TabPage testPage = tabControl_qlbh.TabPages["tp_khachhang"];
            tabControl_qlbh.SelectedTab = testPage;
           // loadKhachHang();
            dgv_khachhang_main.DataSource = khachhangBUS.GetTable();
            //load data customer
        }

        private void btn_menu_hangtonkho_Click(object sender, EventArgs e)
        {
            if (!tabControl_qlbh.TabPages.ContainsKey("tp_hangtonkho"))
            {
                tabControl_qlbh.TabPages.Add(tp_hangtonkho);
            }
            TabPage testPage = tabControl_qlbh.TabPages["tp_hangtonkho"];
            tabControl_qlbh.SelectedTab = testPage;

            HangTonKhoBUS htk = new HangTonKhoBUS();
            List<object> list = htk.getAll();
            tb_hangtonkho_timkiem.Clear();
            _dtHangTonKho.Clear();
            renderHangTonKho(list);

            //NhanVienBUS nv = new NhanVienBUS();
            //List<object> list = nv.Login(tendn, matkhau);
            //dgv_hangtonkho_main.DataSource = list;
        }

        /*private void btn_menu_thongke_Click(object sender, EventArgs e)
        {
            if (!tabControl_qlbh.TabPages.ContainsKey("tp_thongke"))
            {
                tabControl_qlbh.TabPages.Add(tp_thongke);
            }
            TabPage testPage = tabControl_qlbh.TabPages["tp_thongke"];
            tabControl_qlbh.SelectedTab = testPage;

            //Ngay
            dTime_thongke_tuNgay.Value = DateTime.Now;
            dTime_thongke_denNgay.Value = DateTime.Now;
            dTime_thongke_tuNgay.ShowUpDown = true;
            dTime_thongke_denNgay.ShowUpDown = true;

            //Thang
            dTime_thongke_thang1.Value = DateTime.Now;
            dTime_thongke_thang2.Value = DateTime.Now;
            dTime_thongke_thang1.CustomFormat = "MM/yyyy";
            dTime_thongke_thang2.CustomFormat = "MM/yyyy";
            dTime_thongke_thang1.ShowUpDown = true;
            dTime_thongke_thang2.ShowUpDown = true;

            //Qui
            dTime_thongke_namQui1.Value = DateTime.Now;
            dTime_thongke_namQui2.Value = DateTime.Now;
            dTime_thongke_namQui1.CustomFormat = "yyyy";
            dTime_thongke_namQui2.CustomFormat = "yyyy";
            dTime_thongke_namQui1.ShowUpDown = true;
            dTime_thongke_namQui2.ShowUpDown = true;

            cb_thongke_qui1.Items.Clear();
            cb_thongke_qui2.Items.Clear();
            string[] qui = { "1", "2", "3", "4" };
            cb_thongke_qui1.Items.AddRange(qui);
            cb_thongke_qui2.Items.AddRange(qui);
            cb_thongke_qui1.SelectedIndex = 0;
            cb_thongke_qui2.SelectedIndex = 0;

            //Nam
            dTime_thongke_nam1.Value = DateTime.Now;
            dTime_thongke_nam2.Value = DateTime.Now;
            dTime_thongke_nam1.CustomFormat = "yyyy";
            dTime_thongke_nam2.CustomFormat = "yyyy";
            dTime_thongke_nam1.ShowUpDown = true;
            dTime_thongke_nam2.ShowUpDown = true;

            //set location
            gb_thongke_Thang.Location = gb_thongke_Ngay.Location;// new System.Drawing.Point(gb_BCTT_Thang.Location);
            gb_thongke_Qui.Location = gb_thongke_Ngay.Location;
            gb_thongke_Nam.Location = gb_thongke_Ngay.Location;
        }*/
        NhacungcapBUS nhacungcapBUS = new NhacungcapBUS();
        private void btn_menu_nhacungcap_Click(object sender, EventArgs e)
        {
            if (!tabControl_qlbh.TabPages.ContainsKey("tp_nhacungcap"))
            {
                tabControl_qlbh.TabPages.Add(tp_nhacungcap);
            }
            TabPage testPage = tabControl_qlbh.TabPages["tp_nhacungcap"];
            tabControl_qlbh.SelectedTab = testPage;
            dgv_nhacungcap_main.DataSource = nhacungcapBUS.GetTable();
        }
        DonvitinhBUS DonvitinhBUS = new DonvitinhBUS();
       /* private void btn_menu_donvitinh_Click(object sender, EventArgs e)
        {
            if (!tabControl_qlbh.TabPages.ContainsKey("tp_donvitinh"))
            {
                tabControl_qlbh.TabPages.Add(tp_donvitinh);
            }
            TabPage testPage = tabControl_qlbh.TabPages["tp_donvitinh"];
            tabControl_qlbh.SelectedTab = testPage;
            dgv_donvitinh_main.DataSource = DonvitinhBUS.GetTable();
        }*/
        LoaihangBUS LoaihangBUS = new LoaihangBUS();
        private void btn_menu_loaihang_Click(object sender, EventArgs e)
        {
            if (!tabControl_qlbh.TabPages.ContainsKey("tp_loaihang"))
            {
                tabControl_qlbh.TabPages.Add(tp_loaihang);
            }
            TabPage testPage = tabControl_qlbh.TabPages["tp_loaihang"];
            tabControl_qlbh.SelectedTab = testPage;
            dgv_loaihang_main.DataSource = LoaihangBUS.GetTable();
        }

       /* private void btn_banhang_xuathd_Click(object sender, EventArgs e)
        {
            _dtBanHangMain.Clear();
            _dtBanHangMatHang.Clear();
            _dtBanHangHoaDon.Clear();
            dgv_banhang_main.DataSource = _dtBanHangMain;
            tb_banhang_timkiem_barcode.Clear();
            tb_banhang_timkiem_mathang.Clear();
            tb_banhang_timkiem_hoadon.Clear();
            tb_banhang_tongtien.Clear();

            loadHDX();
        }*/

       

       /* private void updateListBanHangMatHang(object list)
        {
            MATHANG.setData(list);
            if (MATHANG.SOLUONG <= 0)
            {
                MessageBox.Show("Sản Phẩm Hết Hàng!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;
            Int64 tongtien = 0;
            int idx = 0;
            for (int i = 0; i < dgv_banhang_main.Rows.Count; i++)
            {
                int soluong = Convert.ToInt32(dgv_banhang_main.Rows[i].Cells["SL"].Value.ToString());
                int gianban = Convert.ToInt32(dgv_banhang_main.Rows[i].Cells["Giá Bán"].Value.ToString());

                if (dgv_banhang_main.Rows[i].Cells["MAHANG"].Value.ToString() == MATHANG.MAHANG.ToString())
                {
                    found = true;
                    idx = i;
                    soluong++;
                    int thanhtien = soluong * gianban;
                    dgv_banhang_main.Rows[i].Cells["SL"].Value = soluong;
                    dgv_banhang_main.Rows[i].Cells["Thành Tiền"].Value = thanhtien;

                }

                tongtien += (soluong * gianban);
            }

            if (!found)
            {
                tongtien += MATHANG.GIABAN;
                int rowCount = dgv_banhang_main.Rows.Count;
                idx = rowCount;

                DataRow row = _dtBanHangMain.NewRow();
                row["STT"] = rowCount + 1;
                row["Tên Mặt Hàng"] = MATHANG.TENHANG;
                row["ĐVT"] = "";
                row["SL"] = 1;
                row["Giá Nhập"] = MATHANG.GIANHAP;
                row["Giá Bán"] = MATHANG.GIABAN;
                row["Thành Tiền"] = MATHANG.GIABAN;
                row["MAHANG"] = MATHANG.MAHANG;

                _dtBanHangMain.Rows.Add(row);
                dgv_banhang_main.DataSource = _dtBanHangMain;

                //var emp = new
                //{
                //    MAHANG = MATHANG.MAHANG,
                //    STT = +1,
                //    TENHANG = MATHANG.TENHANG,
                //    TENDONVITINH = "Updating",
                //    SOLUONG = rowCount+1,
                //    GIANHAP = MATHANG.GIANHAP,
                //    GIABAN = MATHANG.GIABAN,
                //    THANHTIEN = MATHANG.GIABAN

                //};

                //if (rowCount == 0)
                //{
                //    dsBanHang.Add(emp);
                //    dgv_banhang_main.DataSource = dsBanHang;
                //}

                //dgvShowCustomColumns(dgv_banhang_main, new string[] { "STT", "TENHANG", "TENDONVITINH", "SOLUONG", "GIABAN", "THANHTIEN" });
                dgvShowCustomColumns(dgv_banhang_main, new string[] { "STT", "Tên Mặt Hàng", "ĐVT", "SL", "Giá Bán", "Thành Tiền" });
                dgvReadOnlyCustomColumns(dgv_banhang_main, new string[] { "SL" });
                dgv_banhang_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            try
            {
                dgv_banhang_main.Rows[idx].Cells["SL"].Selected = true;
            }
            catch (Exception) { }
            tb_banhang_tongtien.Text = tongtien.ToString();
        }
        private void tb_banhang_timkiem_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = tb_banhang_timkiem_barcode.Text.Trim();
                MatHangBUS mh = new MatHangBUS();
                List<object> list = mh.searchByBarcode(search);
                if (list.Count > 0)
                {
                    updateListBanHangMatHang(list[0]);
                }
                else
                {
                    MessageBox.Show("Mã Barcode Không tồn tại!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tb_banhang_timkiem_mathang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = tb_banhang_timkiem_mathang.Text.Trim();
                MatHangBUS mh = new MatHangBUS();
                List<object> list = mh.searchByTenHang(search);
                _dtBanHangMatHang.Clear();
                for (var i = 0; i < list.Count; i++)
                {
                    MATHANG.setData(list[i]);
                    DataRow row = _dtBanHangMatHang.NewRow();
                    row["STT"] = i + 1;
                    row["Tên Mặt Hàng"] = MATHANG.TENHANG;
                    row["ĐVT"] = "";
                    row["SL"] = MATHANG.SOLUONG;
                    row["Giá Nhập"] = MATHANG.GIANHAP;
                    row["Giá Bán"] = MATHANG.GIABAN;
                    row["Thành Tiền"] = MATHANG.GIABAN;
                    row["MAHANG"] = MATHANG.MAHANG;

                    _dtBanHangMatHang.Rows.Add(row);
                }
                dgv_banhang_mathang.DataSource = _dtBanHangMatHang;
                dgvShowCustomColumns(dgv_banhang_mathang, new string[] { "Tên Mặt Hàng" });
                dgv_banhang_mathang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        
        private void dgv_banhang_main_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgv_banhang_main.Rows.Count > 0)
                btn_banhang_xuathd.Enabled = true;
        }

        private void dgv_banhang_main_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgv_banhang_main.Rows.Count == 0)
                btn_banhang_xuathd.Enabled = false;
        }
        
        private void dgv_banhang_mathang_DoubleClick(object sender, EventArgs e)
        {
            int idx = 0;
            try
            {
                idx = dgv_banhang_mathang.CurrentCell.RowIndex;
                if (idx == -1) return;
            }
            catch { return; }

            int mahang = Convert.ToInt32(_dtBanHangMatHang.Rows[idx]["MAHANG"].ToString());
            MatHangBUS mh = new MatHangBUS();
            List<object> list = mh.searchByMaHang(mahang);
            if (list.Count > 0)
            {
                updateListBanHangMatHang(list[0]);
            }
        }
        */
        private void dgv_banhang_hoadon_DoubleClick(object sender, EventArgs e)
        {

        }

        /*private void dgv_banhang_main_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int idx = 0;
            try
            {
                idx = dgv_banhang_main.CurrentCell.RowIndex;
                if (idx == -1) return;
            }
            catch { return; }

            int soluong = 1;
            try
            {
                soluong = Convert.ToInt32(dgv_banhang_main.Rows[idx].Cells["SL"].Value.ToString());
                if (soluong < 1)
                {
                    soluong = 1;
                    dgv_banhang_main.Rows[idx].Cells["SL"].Value = 1;
                }
            }
            catch (Exception)
            {
                dgv_banhang_main.Rows[idx].Cells["SL"].Value = 1;
            }

            try
            {
                int mahang = Convert.ToInt32(dgv_banhang_main.Rows[idx].Cells["MAHANG"].Value.ToString());
                MatHangBUS mh = new MatHangBUS();
                List<object> list = mh.searchByMaHang(mahang);
                if (list.Count > 0)
                {
                    MATHANG.setData(list[0]);
                    if (soluong > MATHANG.SOLUONG)
                        dgv_banhang_main.Rows[idx].Cells["SL"].Value = MATHANG.SOLUONG;

                }
            }
            catch
            {
            }

            int giaban = Convert.ToInt32(dgv_banhang_main.Rows[idx].Cells["Giá Bán"].Value.ToString());
            dgv_banhang_main.Rows[idx].Cells["Thành Tiền"].Value = soluong * giaban;

            int tongtien = 0;
            for (int i = 0; i < dgv_banhang_main.Rows.Count; i++)
            {
                tongtien += Convert.ToInt32(dgv_banhang_main.Rows[idx].Cells["Thành Tiền"].Value.ToString());
            }
            tb_banhang_tongtien.Text = tongtien.ToString();
        }
        */
        private void dgv_hangtonkho_main_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int idx = 0;
            try
            {
                idx = dgv_hangtonkho_main.CurrentCell.RowIndex;
                if (idx == -1) return;
            }
            catch { return; }

            int soluong = 0;
            Int64 giaban = 0;
            Int64 gianhap = 0;
            try
            {
                soluong = Convert.ToInt32(dgv_hangtonkho_main.Rows[idx].Cells["SL"].Value.ToString());
                if (soluong < 0)
                {
                    soluong = 0;
                    dgv_hangtonkho_main.Rows[idx].Cells["SL"].Value = 0;
                }
            }
            catch (Exception)
            {
                dgv_hangtonkho_main.Rows[idx].Cells["SL"].Value = 0;
            }
            try
            {
                gianhap = Convert.ToInt64(dgv_hangtonkho_main.Rows[idx].Cells["Giá Nhập"].Value.ToString());
                if (gianhap < 0)
                {
                    gianhap = 0;
                    dgv_hangtonkho_main.Rows[idx].Cells["Giá Nhập"].Value = 0;
                }
            }
            catch (Exception)
            {
                dgv_hangtonkho_main.Rows[idx].Cells["Giá Nhập"].Value = 0;
            }
            try
            {
                giaban = Convert.ToInt64(dgv_hangtonkho_main.Rows[idx].Cells["Giá Bán"].Value.ToString());
                if (giaban < 0)
                {
                    giaban = 0;
                    dgv_hangtonkho_main.Rows[idx].Cells["Giá Bán"].Value = 0;
                }
            }
            catch (Exception)
            {
                dgv_hangtonkho_main.Rows[idx].Cells["Giá Bán"].Value = 0;
            }
            dgv_hangtonkho_main.Rows[idx].Cells["Lợi Nhuận"].Value = giaban - gianhap;
            dgv_hangtonkho_main.Rows[idx].Cells["Tổng GN"].Value = giaban * soluong;
            dgv_hangtonkho_main.Rows[idx].Cells["Tổng GB"].Value = gianhap * soluong;


            try
            {
                int mahang = Convert.ToInt32(dgv_hangtonkho_main.Rows[idx].Cells["MAHANG"].Value.ToString());
                HangTonKhoBUS htk = new HangTonKhoBUS();
                htk.update(mahang, soluong, gianhap, giaban, DateTime.Now);
            }
            catch
            {
                string search = tb_hangtonkho_timkiem.Text.Trim();
                HangTonKhoBUS htk = new HangTonKhoBUS();
                List<object> list = htk.search(search);
                _dtHangTonKho.Clear();
                renderHangTonKho(list);
            }

        }

        private void renderHangTonKho(List<object> list)
        {
            for (var i = 0; i < list.Count; i++)
            {
                HANGTONKHO.setData(list[i]);
                DataRow row = _dtHangTonKho.NewRow();
                row["STT"] = i + 1;
                row["Tên Mặt Hàng"] = HANGTONKHO.TENHANG;
                row["Tên NCC"] = HANGTONKHO.TENNHACUNGCAP;
                row["Tên ĐVT"] = HANGTONKHO.TENDONVITINH;
                row["Tên LH"] = HANGTONKHO.TENLOAIHANG;
                row["SL"] = HANGTONKHO.SOLUONG;
                row["Giá Nhập"] = HANGTONKHO.GIANHAP;
                row["Lợi Nhuận"] = HANGTONKHO.TIENLOI;
                row["Giá Bán"] = HANGTONKHO.GIABAN;
                row["Tổng GN"] = HANGTONKHO.TOTAL_SL_GN;
                row["Tổng GB"] = HANGTONKHO.TOTAL_SL_GB;
                row["Ngày Cập Nhật"] = HANGTONKHO.NGAYCAPNHAT;
                row["MAHANG"] = HANGTONKHO.MAHANG;

                _dtHangTonKho.Rows.Add(row);
            }
            dgv_hangtonkho_main.DataSource = _dtHangTonKho;
            dgv_hangtonkho_main.Columns["MAHANG"].Visible = false;
            dgvReadOnlyCustomColumns(dgv_hangtonkho_main, new string[] { "SL", "Giá Nhập", "Giá Bán" });
            dgv_hangtonkho_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void tb_hangtonkho_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = tb_hangtonkho_timkiem.Text.Trim();
                HangTonKhoBUS htk = new HangTonKhoBUS();
                List<object> list = htk.search(search);
                _dtHangTonKho.Clear();
                renderHangTonKho(list);
            }
        }

       /* private void delete_row_BanHangMain(int rowindex)
        {
            if (rowindex == -1) return;

            int cRows = dgv_banhang_main.Rows.Count;
            if (cRows == 0) return;
            _dtBanHangMain.Rows[rowindex].Delete();
            cRows--;
            Int64 tongtien = 0;
            for (int i = 0; i < cRows; i++)
            {
                _dtBanHangMain.Rows[i]["STT"] = (i + 1).ToString();
                tongtien += Convert.ToInt64(_dtBanHangMain.Rows[i]["Thành Tiền"].ToString());
            }

            dgv_banhang_main.DataSource = _dtBanHangMain;
            if (rowindex > 0)
                dgv_banhang_main.Rows[rowindex - 1].Cells["SL"].Selected = true;

            tb_banhang_tongtien.Text = tongtien.ToString();
        }
        */
        private void dgv_banhang_main_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                e.ContextMenuStrip = contextMenuStrip;
                rowNum_banhang_main = e.RowIndex;
            }
            else rowNum_banhang_main = -1;
        }

       /* private void xóaDòngNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_row_BanHangMain(rowNum_banhang_main);
        }

        private void dgv_banhang_main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;
            e.Handled = true;
            try
            {
                int rowindex = dgv_banhang_main.CurrentRow.Index;
                delete_row_BanHangMain(rowindex);
            }
            catch { }
        }*/

       /* private void rbt_thongke_ngay_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton bt = (System.Windows.Forms.RadioButton)sender;

            if (bt.Text == "Ngày")
            {
                gb_thongke_Ngay.Visible = true;

                gb_thongke_Thang.Visible = false;
                gb_thongke_Qui.Visible = false;
                gb_thongke_Nam.Visible = false;
            }
            else if (bt.Text == "Tháng")
            {
                gb_thongke_Thang.Visible = true;

                gb_thongke_Ngay.Visible = false;
                gb_thongke_Qui.Visible = false;
                gb_thongke_Nam.Visible = false;
            }
            else if (bt.Text == "Quí")
            {
                gb_thongke_Qui.Visible = true;

                gb_thongke_Ngay.Visible = false;
                gb_thongke_Thang.Visible = false;
                gb_thongke_Nam.Visible = false;
            }
            else if (bt.Text == "Năm")
            {
                gb_thongke_Nam.Visible = true;

                gb_thongke_Ngay.Visible = false;
                gb_thongke_Thang.Visible = false;
                gb_thongke_Qui.Visible = false;
            }

        }
        */
        private void dgv_banhang_main_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //dgv_banhang_main_CellEndEdit(sender, e);
        }

        private void tb_dangnhap_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_dangnhap_login_Click(sender, e);
        }

        private void tb_dangnhap_username_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_dangnhap_login_Click(sender, e);
        }

        private void dgv_mathang_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int idx = 0;
            try
            {
                idx = dgv_mathang_main.CurrentCell.RowIndex;
                if (idx == -1) return;
                dgv_mamathang = Convert.ToInt32(dgv_mathang_main.Rows[idx].Cells["MAHANG"].Value.ToString());
                btn_mathang_xoa.Enabled = true;
            }
            catch { return; }
        }

        

        private void btn_mathang_themmoi_Click(object sender, EventArgs e)
        {

            

        }

        private void btn_khachhang_themmoi_Click(object sender, EventArgs e)
        {
            string tenkhachhang, diachi, email, dienthoai, fax;
           
           // int makhachhang;
            //makhachhang = int.Parse(tb_khachhang_makh.Text);
            tenkhachhang = tb_khachhang_tenkh.Text;
            diachi = tb_khachhang_diachi.Text;
            email = tb_khachhang_email.Text;
            dienthoai = tb_khachhang_dienthoai.Text;
            fax = tb_khachhang_fax.Text;
            KhachHangDTO KhachHangDTO = new KhachHangDTO(/*makhachhang, */tenkhachhang, diachi, email, dienthoai, fax);
            try
            {
                int numberOfRows = khachhangBUS.Add(KhachHangDTO);
                if (numberOfRows > 0)
                    dgv_khachhang_main.DataSource = khachhangBUS.GetTable();
                   // dgvProduct.DataSource = productBUS.GetData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" loi them san pham. \n " + ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        
        private void btn_nhacungcap_themmoi_Click(object sender, EventArgs e)
        {
            string tennhacungcap, diachi, email, dienthoai, fax;

         //   int manhacungcap;
          //  manhacungcap = int.Parse(tb_nhacungcap_mancc.Text);
            tennhacungcap = tb_nhacungcap_tenncc.Text;
            diachi = tb_nhacungcap_diachi.Text;
            email = tb_nhacungcap_email.Text;
            dienthoai = tb_nhacungcap_dienthoai.Text;
            fax = tb_nhacungcap_fax.Text;
            NhacungcapDTO NhacungcapDTO = new NhacungcapDTO(tennhacungcap, diachi, email, dienthoai, fax);
            try
            {
                
                int numberOfRows = nhacungcapBUS.Add(NhacungcapDTO);
                if (numberOfRows > 0)
                    dgv_nhacungcap_main.DataSource = nhacungcapBUS.GetTable();
                // dgvProduct.DataSource = productBUS.GetData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" loi them san pham. \n " + ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_nhacungcap_xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_mathang_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_mamathang > 0)
                {
                    MatHangBUS mt = new MatHangBUS();
                    mt.Delete(dgv_mamathang);
                    dgv_mamathang = 0;
                    btn_mathang_xoa.Enabled = false;
                    MessageBox.Show("Xóa Mặt Hàng Thành Công!", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMatHang();
                }
            }
            catch { return; }
        }

        private void tp_dangnhap_Click(object sender, EventArgs e)
        {

        }

        int index;
        private void dgv_khachhang_main_Click(object sender, EventArgs e)
        {
            index = dgv_khachhang_main.CurrentRow.Index;
            tb_khachhang_tenkh.Text = dgv_khachhang_main.Rows[index].Cells[1].Value.ToString();
            tb_khachhang_diachi.Text = dgv_khachhang_main.Rows[index].Cells[2].Value.ToString();
            tb_khachhang_email.Text = dgv_khachhang_main.Rows[index].Cells[3].Value.ToString();
            tb_khachhang_dienthoai.Text = dgv_khachhang_main.Rows[index].Cells[4].Value.ToString();
            tb_khachhang_fax.Text = dgv_khachhang_main.Rows[index].Cells[5].Value.ToString();
        }
        int index1;
        private void dgv_loaihang_main_Click(object sender, EventArgs e)
        {
            index1 = dgv_loaihang_main.CurrentRow.Index;
            tb_loaihang_tenlh.Text= dgv_loaihang_main.Rows[index1].Cells[1].Value.ToString();

        }
        int index2;
        private void dgv_nhacungcap_main_Click(object sender, EventArgs e)
        {
            index2 = dgv_nhacungcap_main.CurrentRow.Index;
            tb_nhacungcap_tenncc.Text = dgv_nhacungcap_main.Rows[index2].Cells[1].Value.ToString();
            tb_nhacungcap_diachi.Text = dgv_nhacungcap_main.Rows[index2].Cells[2].Value.ToString();
            tb_nhacungcap_email.Text = dgv_nhacungcap_main.Rows[index2].Cells[3].Value.ToString();
            tb_nhacungcap_dienthoai.Text = dgv_nhacungcap_main.Rows[index2].Cells[4].Value.ToString();
            tb_nhacungcap_fax.Text = dgv_nhacungcap_main.Rows[index2].Cells[5].Value.ToString();
        }

        int index3;
        private void dgv_mathang_main_Click(object sender, EventArgs e)
        {
            index3 = dgv_mathang_main.CurrentRow.Index;
            tb_mathang_tenmh.Text = dgv_mathang_main.Rows[index3].Cells[1].Value.ToString();
            tb_mathang_soluong.Text = dgv_mathang_main.Rows[index3].Cells[4].Value.ToString();
            tb_mathang_gianhap.Text = dgv_mathang_main.Rows[index3].Cells[5].Value.ToString();
            tb_mathang_giaban.Text = dgv_mathang_main.Rows[index3].Cells[6].Value.ToString();
        }

        

        //private void ketnoi()
        //{
        //    try
        //    {
        //        SqlConnection kn = new SqlConnection(@"Data Source=.\SQL2014;Initial Catalog=QLBH;Integrated Security=True");
        //        kn.Open();
        //        string sql = "select * from KHACHHANG";
        //        SqlCommand commandsql = new SqlCommand(sql, kn); //th?c thi các câu l?nh trong sql
        //        SqlDataAdapter com = new SqlDataAdapter(commandsql); // V?n chuy?n d? li?u
        //        DataTable table = new DataTable(); // t?o b?ng ?o trong h? th?ng
        //        com.Fill(table); // d? d? li?u vào b?ng ?o
        //        dgv_khachhang_main.DataSource = table; // b?ng ?o du?c dua vào dataGridview
        //    }
        //    catch
        //    {
        //        MessageBox.Show("L?i k?t n?i vui lòng ki?m tra l?i!");
        //    }
        //    finally
        //    {
        //        SqlConnection kn = new SqlConnection(@"Data Source=.\SQL2014;Initial Catalog=QLBH;Integrated Security=True");
        //        kn.Close();
        //    }

        //}

        //string xoakhachhang;
        //string xoa;
        //private void btn_khachhang_xoa_Click(object sender, EventArgs e)
        //{
        //    SqlConnection kn = new SqlConnection(@"Data Source=.\SQL2014;Initial Catalog=QLBH;Integrated Security=True");
        //    kn.Open();
        //    xoakhachhang = "delete KHACHHANG where MAKHACHHANG = '" + tb_khachhang_tenkh + "' ";
        //    xoa = "delete HOADONXUAT where MAKHACHHANG = '" + tb_khachhang_tenkh + "' ";
        //    SqlCommand comm = new SqlCommand(xoakhachhang, kn);
        //    SqlCommand conn = new SqlCommand(xoa, kn);
        //    comm.ExecuteNonQuery();
        //    conn.ExecuteNonQuery();
        //    ketnoi();
            
        //}

     
        
    }

    }

