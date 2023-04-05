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
    public partial class FormHangHoa_DichVu : DevExpress.XtraEditors.XtraForm
    {
        public FormHangHoa_DichVu()
        {
            InitializeComponent();
        }

        HangHoa_DichVu hh_dv;
        bool them;
        int mahanghoa_dichvu;
        private void FormDichVu_Load(object sender, EventArgs e)
        {
            hh_dv = new HangHoa_DichVu();
            loadData();
            showHideConTrol(true);
            txtmahh_dv.Enabled = false;
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
            txttenhh_dv.Enabled = t;
            txtdongia.Enabled = t;
        }

        void reset()
        {
            txtmahh_dv.Text = "";
            txttenhh_dv.Text = "";
            txtdongia.Text = "";
        }
        void loadData()
        {
            gcdanhsach.DataSource = hh_dv.getList();
            gvdanhsach.OptionsBehavior.Editable = false;
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            them = true;
            txtmahh_dv.Enabled = true;
            showHideConTrol(false);
            enabled(true);
            reset();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                hh_dv.delete(int.Parse(mahanghoa_dichvu.ToString()));
            }
            loadData();
            enabled(false);
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            them = false;
            txtmahh_dv.Enabled = false;
            showHideConTrol(false);
            enabled(true);
        }

        private void tsbluu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                tb_hanghoa_dichvu hanghoa_Dichvu = new tb_hanghoa_dichvu();
                hanghoa_Dichvu.MaHH_DV = int.Parse(txtmahh_dv.Text.ToString());
                hanghoa_Dichvu.TenHH_DV = txttenhh_dv.Text;
                hanghoa_Dichvu.DonGia = int.Parse(txtdongia.Text);
                hh_dv.add(hanghoa_Dichvu);
            }
            else
            {
                tb_hanghoa_dichvu hanghoa_Dichvu = hh_dv.getItem(mahanghoa_dichvu);
                hanghoa_Dichvu.TenHH_DV = txttenhh_dv.Text;
                hanghoa_Dichvu.DonGia = int.Parse(txtdongia.Text);
                hh_dv.update(hanghoa_Dichvu);
            }
            them = false;
            loadData();
            showHideConTrol(true);
            enabled(false);
            txtmahh_dv.Enabled=false;   
        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbtrove_Click(object sender, EventArgs e)
        {
            them = false;
            txtmahh_dv.Enabled = false;
            showHideConTrol(true);
            enabled(false);
        }
        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                mahanghoa_dichvu = int.Parse(gvdanhsach.GetFocusedRowCellValue("MaHH_DV").ToString());
                txtmahh_dv.Text = gvdanhsach.GetFocusedRowCellValue("MaHH_DV").ToString();
                txttenhh_dv.Text = gvdanhsach.GetFocusedRowCellValue("TenHH_DV").ToString();
                txtdongia.Text = gvdanhsach.GetFocusedRowCellValue("DonGia").ToString();
            }
        }

   
    }
}