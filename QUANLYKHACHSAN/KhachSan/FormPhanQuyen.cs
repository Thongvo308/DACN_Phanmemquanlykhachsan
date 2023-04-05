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
    public partial class FormPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public FormPhanQuyen()
        {
            InitializeComponent();
        }


        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source=DESKTOP-A9L9K71\SQLEXPRESS;initial catalog=quanlykhachsan;integrated security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_taiKhoan where TenDN = N'"+txtuser.Text+"'and MatKhau = N'"+txtpassword.Text+"'",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string tendn = txtuser.Text;
            string matkhau = txtpassword.Text;
            if (tendn == "") MessageBox.Show("Vui lòng nhập tên đăng nhập!");
            else if (matkhau == "") MessageBox.Show("Vui lòng nhập mật khẩu!");
            else
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormQLChung main = new FormQLChung(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Tên tài đăng nhập hoặc mật khẩu không chính sát!");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}