using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace KhachSan
{
    public partial class FormDatPhongDon : DevExpress.XtraEditors.XtraForm
    {
        public FormDatPhongDon()
        {
            InitializeComponent();
        }

        bool _them;
        int _maphong;
        int _madat = 0;

        DatPhong _datphong;     
        DatPhong_HH_DV _datphong_hhdv;
        ChiTiet_DatPhong _chitietdatphong;
        Phong _phong;
        OBJ_Phong _phonghientai;
        KhachHang _khachhang;
        HangHoa_DichVu _hanghoa_dichvu;
        List<OBJ_DP_DV> lstDP_DV;

        private void FormDatPhongDon_Load(object sender, EventArgs e)
        {
            _datphong = new DatPhong();
            _datphong_hhdv = new DatPhong_HH_DV();
            _chitietdatphong = new ChiTiet_DatPhong();
            _phong = new Phong();
            _khachhang = new KhachHang();
            _hanghoa_dichvu = new HangHoa_DichVu();
            lstDP_DV = new List<OBJ_DP_DV>();
          //  _phonghientai = _phong.getItemFull(_maphong);
            //lblphong.Text = _phonghientai.TenPhong +"- Đơn giá:"+_phonghientai.DonGia.ToString("N0")+"VNĐ";
            dtngaydat.Value = DateTime.Now;
            dtngaytra.Value = DateTime.Now.AddDays(1);
            cbott.DataSource = TRANGTHAI.getList();
            cbott.ValueMember = "value";
            cbott.DisplayMember = "display";
            spsonguoio.Text = "1";
            loadKH();
            loadHH_DV();

        }

        public void loadKH()
        {
            KhachHang _khachhang = new KhachHang();
            searchkh.Properties.DataSource = _khachhang.getAll();
            searchkh.Properties.ValueMember = "MaKH";
            searchkh.Properties.DisplayMember = "TenKH";

        }
        void loadHH_DV()
        {
            _hanghoa_dichvu = new HangHoa_DichVu();
            gcdv.DataSource = _hanghoa_dichvu.getList();
            gvdv.OptionsBehavior.Editable = false;
        }

        public void getKH(int makh)
        {
            KhachHang _khachhang = new KhachHang();
            var kh = _khachhang.getItem(makh);
            searchkh.EditValue = kh.MaKH;
            searchkh.Text = kh.TenKH;

        }

        public void setkhachhang(int makh)
        {
            var kh = _khachhang.getItem(makh);
        }


        private void tsbluu_Click(object sender, EventArgs e)
        {

        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            Khách_Hàng kh = new Khách_Hàng();
            kh.kh_dp = "datphongdon";
            kh.ShowDialog();
        }

        private void gcdv_DoubleClick(object sender, EventArgs e)
        {
            if (_maphong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gvdv.GetFocusedRowCellValue("MaHH_DV") != null)
            {
                OBJ_DP_DV dv = new OBJ_DP_DV();
                dv.MaHH_DV = int.Parse(gvdv.GetFocusedRowCellValue("MaHH_DV").ToString());
                dv.TenHH_DV = gvdv.GetFocusedRowCellValue("TenHH_DV").ToString();
                dv.MaPhong = _maphong;
                dv.TenPhong = _phonghientai.TenPhong;
                dv.DonGia = float.Parse(gvdv.GetFocusedRowCellValue("DonGia").ToString());
                dv.SoLuong = 1;
                dv.ThanhTien = dv.DonGia * dv.SoLuong;
                foreach (var item in lstDP_DV)
                {
                    if (item.MaHH_DV == dv.MaHH_DV && item.MaPhong == dv.MaPhong)
                    {
                        item.SoLuong = item.SoLuong + 1;
                        item.ThanhTien = item.SoLuong * item.DonGia;
                        loadDP_DV();
                        return;
                    }
                }
                lstDP_DV.Add(dv);
            }
            loadDP_DV();
            txtthanhtien.Text = gvdsdichvu.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString();

        }

        void loadDP_DV()
        {
            List<OBJ_DP_DV> lsdp = new List<OBJ_DP_DV>();
            foreach (var item in lstDP_DV)
            {
                lsdp.Add(item);
            }
            gcdsdichvu.DataSource = lsdp;
        }

        private void gvdsdichvu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column.FieldName == "SoLuong")
            {
                int sl = int.Parse(e.Value.ToString());
                if (sl != 0)
                {
                    double gia = double.Parse(gvdsdichvu.GetRowCellValue(gvdsdichvu.FocusedRowHandle, "DonGia").ToString());
                    gvdsdichvu.SetRowCellValue(gvdsdichvu.FocusedRowHandle, "ThanhTien", sl * gia);
                }

                else
                {
                    gvdsdichvu.SetRowCellValue(gvdsdichvu.FocusedRowHandle, "ThanhTien", 0);
                }
            }
            gvdsdichvu.UpdateTotalSummary();
            txtthanhtien.Text = gvdsdichvu.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString();
        }

        private void gvdsdichvu_HiddenEditor(object sender, EventArgs e)
        {
            gvdsdichvu.UpdateCurrentRow();
        }
    }
}