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
    public partial class FormLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public FormLoaiPhong()
        {
            InitializeComponent();
        }

        LoaiPhong lp;
        bool them;
        int maloai;
        private void FormLoaiPhong_Load(object sender, EventArgs e)
        {
            lp = new LoaiPhong();
            loadData();
            showHideConTrol(true);
            txtmaloai.Enabled = false;
            enabled(false);

        }

        void showHideConTrol(bool t)
        {
            tsbluu.Visible = !t;
            tsbtrove.Visible = !t;
            tsbsua.Visible = t;
            tsbthoat.Visible = t;
            tsbxoa.Visible = t;
            tsbthem .Visible = t;
        }

        void enabled(bool t)
        {
            txtten.Enabled = t;
            txtdongia.Enabled = t;
            txtsogiuong.Enabled=t;
            txtsonguoi.Enabled = t;
        }
 
        void reset()
        {
            txtmaloai.Text = "";
            txtten.Text = "";
            txtdongia.Text = "";
            txtsogiuong.Text = "";
            txtsonguoi.Text = "";
        }
        void loadData()
        {
            gcdanhsach.DataSource = lp.getAll();
            gvdanhsach.OptionsBehavior.Editable = false;

        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            them = true;
            txtmaloai.Enabled = true;
            showHideConTrol(false);
            enabled(true);
            reset();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lp.delete(int.Parse(maloai.ToString()));
            }
            loadData();
            enabled(false);
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            them = false;
            txtmaloai.Enabled = false;
            showHideConTrol(false);
            enabled(true);
        }

        private void tsbluu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                tb_loaiphong loaiphong = new tb_loaiphong();
                loaiphong.MaLoai = int.Parse(txtmaloai.Text.ToString());
                loaiphong.TenLoai = txtten.Text;
                loaiphong.DonGia = int.Parse(txtdongia.Text);
                loaiphong.SoGiuong = int.Parse(txtsogiuong.Text);
                loaiphong.SoNguoi = int.Parse(txtsonguoi.Text);
                lp.add(loaiphong);
            }
            else
            {
                tb_loaiphong loaiphong = lp.getItem(maloai);
                loaiphong.TenLoai = txtten.Text;
                loaiphong.DonGia = int.Parse(txtdongia.Text);
                loaiphong.SoGiuong = int.Parse(txtsogiuong.Text);
                loaiphong.SoNguoi = int.Parse(txtsonguoi.Text);
                lp.update(loaiphong);
            }
            them = false;
            loadData();
            showHideConTrol(true);
            enabled(false);
            txtmaloai.Enabled=false;    
        }

        private void tsbtrove_Click(object sender, EventArgs e)
        {
            them = false;
            txtmaloai.Enabled = false;
            showHideConTrol(true);
            enabled(false);
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                maloai = int.Parse(gvdanhsach.GetFocusedRowCellValue("MaLoai").ToString());
                txtmaloai.Text = gvdanhsach.GetFocusedRowCellValue("MaLoai").ToString();
                txtten.Text = gvdanhsach.GetFocusedRowCellValue("TenLoai").ToString();
                txtdongia.Text = gvdanhsach.GetFocusedRowCellValue("DonGia").ToString();
                txtsogiuong.Text = gvdanhsach.GetFocusedRowCellValue("SoGiuong").ToString();
                txtsonguoi.Text = gvdanhsach.GetFocusedRowCellValue("SoNguoi").ToString();
            }

        }

        private void gvdanhsach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(e.Column.Name=="DISABLED" && bool.Parse(e.CellValue.ToString())==true)
            {
                Image img = Properties.Resources.daux;
                e.Graphics.DrawImage(img,e.Bounds.X,e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtsogiuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}