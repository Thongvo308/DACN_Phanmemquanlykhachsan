using BusinessLayer;
using DataLayer;
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

namespace KhachSan
{
    public partial class Nhân_viên : DevExpress.XtraEditors.XtraForm
    {
        public Nhân_viên()
        {
            InitializeComponent();
        }

       

        NhanVien nv;
        bool them;
        int manhanvien;

        private void Nhân_viên_Load(object sender, EventArgs e)
        {
            nv = new NhanVien();
            loadData();
            showHideConTrol(true);
            txtmanv.Enabled = false;
            enabled(false);
        }

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
            txttennv.Enabled = t;
            txtdiachi.Enabled = t;
            txtemail.Enabled = t;
            txtsodienthoai.Enabled = t;
        }

        void reset()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            txtsodienthoai.Text = "";
        }
        void loadData()
        {
            gcdanhsach.DataSource = nv.getAll();
            gvdanhsach.OptionsBehavior.Editable = false;

        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            them = true;
            txtmanv.Enabled = true;
            showHideConTrol(false);
            enabled(true);
            reset();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                nv.delete(manhanvien);
            }
            loadData();
            enabled(false);

        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            them = false;
            txtmanv.Enabled = false;
            showHideConTrol(false);
            enabled(true);
        }

        private void tsbluu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                tb_nhanvien nhanvien = new tb_nhanvien();
                nhanvien.MaNV = int.Parse(txtmanv.Text);
                nhanvien.TenNV = txttennv.Text;
                nhanvien.DiaChi = txtdiachi.Text;
                nhanvien.Email = txtemail.Text;
                nhanvien.DienThoai = txtsodienthoai.Text;
                nv.add(nhanvien);
            }
            else
            {
                tb_nhanvien nhanvien = nv.getItem(manhanvien);
                nhanvien.TenNV = txttennv.Text;
                nhanvien.DiaChi = txtdiachi.Text;
                nhanvien.Email = txtemail.Text;
                nhanvien.DienThoai = txtsodienthoai.Text;
                nv.update(nhanvien);
            }
            them = false;
            loadData();
            showHideConTrol(true);
            enabled(false);
            txtmanv.Enabled = false;
        }

        private void tsbtrove_Click(object sender, EventArgs e)
        {
            them = false;
            txtmanv.Enabled = false;
            showHideConTrol(true);
            enabled(false);
        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                manhanvien = int.Parse(gvdanhsach.GetFocusedRowCellValue("MaNV").ToString());
                txtmanv.Text = gvdanhsach.GetFocusedRowCellValue("MaNV").ToString();
                txttennv.Text = gvdanhsach.GetFocusedRowCellValue("TenNV").ToString();
                txtdiachi.Text = gvdanhsach.GetFocusedRowCellValue("DiaChi").ToString();
                txtemail.Text = gvdanhsach.GetFocusedRowCellValue("Email").ToString();
                txtsodienthoai.Text = gvdanhsach.GetFocusedRowCellValue("DienThoai").ToString();
            }

        }

        private void gvdanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DISABLED" && bool.Parse(e.CellValue.ToString()) == true)
            {
                Image img = Properties.Resources.daux;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}