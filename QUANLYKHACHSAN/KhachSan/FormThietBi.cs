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
    public partial class FormThietBi : DevExpress.XtraEditors.XtraForm
    {
        public FormThietBi()
        {
            InitializeComponent();
        }


        ThietBi tb;
        bool them;
        int mathietbi;
        private void FormThietBi_Load(object sender, EventArgs e)
        {
            tb = new ThietBi();
            loadData();
            showHideConTrol(true);
            txtmatb.Enabled = false;
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
            txttentb.Enabled = t;
        }
        void reset()
        {
            txtmatb.Text = "";
            txttentb.Text = "";
        }
        void loadData()
        {
            gcdanhsach.DataSource = tb.getAll();
            gvdanhsach.OptionsBehavior.Editable = false;

        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            them = true;
            txtmatb.Enabled = true;
            showHideConTrol(false);
            enabled(true);
            reset();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tb.delete(int.Parse(mathietbi.ToString()));
            }
            loadData();
            enabled(false);
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            them = false;
            txtmatb.Enabled = false;
            showHideConTrol(false);
            enabled(true);
        }

        private void tsbluu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                tb_thietbi thietbi = new tb_thietbi();
                thietbi.MaTB = int.Parse(txtmatb.Text.ToString());
                thietbi.TenTB = txttentb.Text;
                tb.add(thietbi);
            }
            else
            {
                tb_thietbi thietbi = tb.getItem(mathietbi);
                thietbi.TenTB = txttentb.Text;
                tb.update(thietbi);
            }
            them = false;
            loadData();
            showHideConTrol(true);
            enabled(false);
            txtmatb.Enabled = false;
        }

        private void tsbtrove_Click(object sender, EventArgs e)
        {
            them = false;
            txtmatb.Enabled = false;
            showHideConTrol(true);
            enabled(false);
        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvdanhsanh_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                mathietbi = int.Parse(gvdanhsach.GetFocusedRowCellValue("MaTB").ToString());
                txtmatb.Text = gvdanhsach.GetFocusedRowCellValue("MaTB").ToString();
                txttentb.Text = gvdanhsach.GetFocusedRowCellValue("TenTB").ToString();
            }
        }
        private void gvdanhsanh_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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