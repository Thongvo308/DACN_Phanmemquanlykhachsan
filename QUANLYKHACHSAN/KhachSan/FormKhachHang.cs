using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class Khách_Hàng : DevExpress.XtraEditors.XtraForm
    {
        public Khách_Hàng()
        {
            InitializeComponent();
        }

        private void Khách_hàng_Load(object sender, EventArgs e)

        {
            kh = new KhachHang();
            loadData();
            showHideConTrol(true);
            enabled(false);
            txtmakh.Enabled = false;
        }

        FormDatPhong objDP = (FormDatPhong)Application.OpenForms["FormDatPhong"];
        FormDatPhongDon objDPdon = (FormDatPhongDon)Application.OpenForms["FormDatPhongDon"];
        KhachHang kh;
        bool them;
        int makhachhang;
        public string kh_dp;
    

        void showHideConTrol(bool t)
        {
            tsbluu.Visible = !t;
            tsbtrove.Visible = !t;
            tsbsua.Visible = t;
            tsbthoat.Visible = t;
            tsbxoa.Visible = t;
            tsbthem.Visible = t;
        }

        void enabled(bool t)
        {
            txttenkh.Enabled = t;
            txtdiachi.Enabled = t;
            txtcccd.Enabled = t;
            txtsdt.Enabled = t;
            ckgioitinh.Enabled = t;
        }

        void reset()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdiachi.Text = "";
            txtcccd.Text = "";
            txtsdt.Text = "";
            ckgioitinh.Checked = false;
        }
        void loadData()
        {
            gcdanhsach.DataSource = kh.getAll();
            gvdanhsach.OptionsBehavior.Editable = false;

        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            them = true;
            txtmakh.Enabled = true;
            showHideConTrol(false);
            enabled(true);
            reset();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                kh.delete(int.Parse(makhachhang.ToString()));
            }
            loadData();
            enabled(false);
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            them = false;
            txtmakh.Enabled = false;
            showHideConTrol(false);
            enabled(true);
        }

        private void tsbluu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                tb_khachhang khachhang = new tb_khachhang();
                khachhang.MaKH = int.Parse(txtmakh.Text.ToString());
                khachhang.TenKH = txttenkh.Text;
                khachhang.DienThoai = txtsdt.Text;
                khachhang.DiaChi = txtdiachi.Text;
                khachhang.CCCD = txtcccd.Text;
                khachhang.GioiTinh = ckgioitinh.Checked;
                kh.add(khachhang);
            }
            else
            {
                tb_khachhang khachhang = kh.getItem(makhachhang);
                khachhang.TenKH = txttenkh.Text;
                khachhang.DienThoai = txtsdt.Text;
                khachhang.DiaChi = txtdiachi.Text;
                khachhang.CCCD = txtcccd.Text;
                khachhang.GioiTinh = ckgioitinh.Checked;
                kh.update(khachhang);
            }
            them = false;
            loadData();
            showHideConTrol(true);
            enabled(false);
            txtmakh.Enabled = false;
        }

        private void tsbtrove_Click(object sender, EventArgs e)
        {
            them = false;
            txtmakh.Enabled = false;
            showHideConTrol(true);
            enabled(false);
        }


        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                makhachhang = int.Parse(gvdanhsach.GetFocusedRowCellValue("MaKH").ToString());
                txtmakh.Text = gvdanhsach.GetFocusedRowCellValue("MaKH").ToString();
                txttenkh.Text = gvdanhsach.GetFocusedRowCellValue("TenKH").ToString();
                txtsdt.Text = gvdanhsach.GetFocusedRowCellValue("DienThoai").ToString();
                txtdiachi.Text = gvdanhsach.GetFocusedRowCellValue("DiaChi").ToString();
                txtcccd.Text = gvdanhsach.GetFocusedRowCellValue("CCCD").ToString();
                ckgioitinh.Checked = bool.Parse(gvdanhsach.GetFocusedRowCellValue("GioiTinh").ToString());

            }
        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvdanhsach_DoubleClick(object sender, EventArgs e)
        {
            if (gvdanhsach.GetFocusedRowCellValue("MaKH") != null)
            {
                if(kh_dp == "datphongdon")
                {
                    objDPdon.loadKH();
                    objDPdon.setkhachhang(int.Parse(gvdanhsach.GetFocusedRowCellValue("MaKH").ToString()));
                }
                else
                {
                    objDP.loadKH();
                    objDP.setkhachhang(int.Parse(gvdanhsach.GetFocusedRowCellValue("MaKH").ToString()));
                }
                this.Close();
            }
        }
    }

}