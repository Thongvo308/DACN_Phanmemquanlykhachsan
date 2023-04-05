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
    public partial class Nhà_cung_cấp : DevExpress.XtraEditors.XtraForm
    {
        public Nhà_cung_cấp()
        {
            InitializeComponent();
        }


        NhaCungCap ncc;
        bool them;
        int mancc;
        private void Nhà_cung_cấp_Load(object sender, EventArgs e)
        {
            ncc = new NhaCungCap();
            loadData();
            showHideConTrol(true);
            txtmancc.Enabled = false;
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
            txttenncc.Enabled = t;
            txtdiachi.Enabled = t;
            txtsdt.Enabled = t;
        }

        void reset()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
        }
        void loadData()
        {
            gcdanhsach.DataSource = ncc.getAll();
            gvdanhsach.OptionsBehavior.Editable = false;

        }


        private void tsbthem_Click(object sender, EventArgs e)
        {
            them = true;
            txtmancc.Enabled = true;
            showHideConTrol(false);
            enabled(true);
            reset();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ncc.delete(int.Parse(mancc.ToString()));
            }
            loadData();
            enabled(false);
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            them = false;
            txtmancc.Enabled = false;
            showHideConTrol(false);
            enabled(true);
        }

        private void tsbluu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                tb_nhacungcap nhacungcap = new tb_nhacungcap();
                nhacungcap.MaNCC = int.Parse(txtmancc.Text.ToString());
                nhacungcap.TenNCC = txttenncc.Text;
                nhacungcap.DienThoai = txtsdt.Text;
                nhacungcap.DiaChi = txtdiachi.Text;
                ncc.add(nhacungcap);
            }
            else
            {
                tb_nhacungcap nhacungcap = ncc.getItem(mancc);
                nhacungcap.TenNCC = txttenncc.Text;
                nhacungcap.DienThoai = txtsdt.Text;
                nhacungcap.DiaChi = txtdiachi.Text;
                ncc.update(nhacungcap);
            }
            them = false;
            loadData();
            showHideConTrol(true);
            enabled(false);
            txtmancc.Enabled=false;
        }

        private void tsbtrove_Click(object sender, EventArgs e)
        {
            them = false;
            txtmancc.Enabled = false;
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
                mancc = int.Parse(gvdanhsach.GetFocusedRowCellValue("MaNCC").ToString());
                txtmancc.Text = gvdanhsach.GetFocusedRowCellValue("MaNCC").ToString();
                txttenncc.Text = gvdanhsach.GetFocusedRowCellValue("TenNCC").ToString();
                txtdiachi.Text = gvdanhsach.GetFocusedRowCellValue("DiaChi").ToString();
                txtsdt.Text = gvdanhsach.GetFocusedRowCellValue("DienThoai").ToString();
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}