namespace KhachSan
{
    partial class Nhân_viên
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbthem = new System.Windows.Forms.ToolStripButton();
            this.tsbxoa = new System.Windows.Forms.ToolStripButton();
            this.tsbsua = new System.Windows.Forms.ToolStripButton();
            this.tsbluu = new System.Windows.Forms.ToolStripButton();
            this.tsbtrove = new System.Windows.Forms.ToolStripButton();
            this.tsbthoat = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtemail);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtsodienthoai);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtmanv);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txttennv);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 305);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(767, 144);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(508, 60);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(217, 21);
            this.txtemail.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(602, 95);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(123, 21);
            this.txtsodienthoai.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số điện thoại";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(111, 60);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(68, 21);
            this.txtmanv.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(111, 92);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(391, 21);
            this.txtdiachi.TabIndex = 5;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(273, 60);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(180, 21);
            this.txttennv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên";
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 54);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(767, 255);
            this.gcdanhsach.TabIndex = 9;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNV,
            this.TenNV,
            this.DiaChi,
            this.Email,
            this.DienThoai});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            this.gvdanhsach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvdanhsach_CustomDrawCell);
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            // 
            // MaNV
            // 
            this.MaNV.Caption = "MÃ NHÂN VIÊN";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.MaxWidth = 85;
            this.MaNV.MinWidth = 75;
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 0;
            this.MaNV.Width = 78;
            // 
            // TenNV
            // 
            this.TenNV.Caption = "TÊN NHÂN VIÊN";
            this.TenNV.FieldName = "TenNV";
            this.TenNV.MaxWidth = 150;
            this.TenNV.MinWidth = 140;
            this.TenNV.Name = "TenNV";
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 1;
            this.TenNV.Width = 146;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "ĐỊA CHỈ ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MaxWidth = 250;
            this.DiaChi.MinWidth = 240;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            this.DiaChi.Width = 250;
            // 
            // Email
            // 
            this.Email.Caption = "EMAIL";
            this.Email.FieldName = "Email";
            this.Email.MaxWidth = 90;
            this.Email.MinWidth = 85;
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            this.Email.Width = 88;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "SỐ ĐIỆN THOẠI";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.MaxWidth = 130;
            this.DienThoai.MinWidth = 120;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 4;
            this.DienThoai.Width = 130;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbthem,
            this.tsbxoa,
            this.tsbsua,
            this.tsbluu,
            this.tsbtrove,
            this.tsbthoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(767, 54);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbthem
            // 
            this.tsbthem.Image = global::KhachSan.Properties.Resources.istockphoto_1050864662_612x612;
            this.tsbthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthem.Name = "tsbthem";
            this.tsbthem.Size = new System.Drawing.Size(41, 51);
            this.tsbthem.Text = "Thêm";
            this.tsbthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbthem.Click += new System.EventHandler(this.tsbthem_Click);
            // 
            // tsbxoa
            // 
            this.tsbxoa.Image = global::KhachSan.Properties.Resources.istockphoto_1050831450_612x612;
            this.tsbxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxoa.Name = "tsbxoa";
            this.tsbxoa.Size = new System.Drawing.Size(36, 51);
            this.tsbxoa.Text = "Xoá";
            this.tsbxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbxoa.Click += new System.EventHandler(this.tsbxoa_Click);
            // 
            // tsbsua
            // 
            this.tsbsua.Image = global::KhachSan.Properties.Resources.istockphoto_1050865512_612x612;
            this.tsbsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsua.Name = "tsbsua";
            this.tsbsua.Size = new System.Drawing.Size(36, 51);
            this.tsbsua.Text = "Sửa";
            this.tsbsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbsua.Click += new System.EventHandler(this.tsbsua_Click);
            // 
            // tsbluu
            // 
            this.tsbluu.Image = global::KhachSan.Properties.Resources.istockphoto_1050831766_612x612;
            this.tsbluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbluu.Name = "tsbluu";
            this.tsbluu.Size = new System.Drawing.Size(36, 51);
            this.tsbluu.Text = "Lưu";
            this.tsbluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbluu.Click += new System.EventHandler(this.tsbluu_Click);
            // 
            // tsbtrove
            // 
            this.tsbtrove.Image = global::KhachSan.Properties.Resources.istockphoto_1050831530_612x6121;
            this.tsbtrove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtrove.Name = "tsbtrove";
            this.tsbtrove.Size = new System.Drawing.Size(42, 51);
            this.tsbtrove.Text = "Trở về";
            this.tsbtrove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtrove.Click += new System.EventHandler(this.tsbtrove_Click);
            // 
            // tsbthoat
            // 
            this.tsbthoat.Image = global::KhachSan.Properties.Resources.istockphoto_1050831532_612x6121;
            this.tsbthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthoat.Name = "tsbthoat";
            this.tsbthoat.Size = new System.Drawing.Size(41, 51);
            this.tsbthoat.Text = "Thoát";
            this.tsbthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbthoat.Click += new System.EventHandler(this.tsbthoat_Click);
            // 
            // Nhân_viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 449);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcdanhsach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Nhân_viên";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.Nhân_viên_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbthem;
        private System.Windows.Forms.ToolStripButton tsbxoa;
        private System.Windows.Forms.ToolStripButton tsbsua;
        private System.Windows.Forms.ToolStripButton tsbluu;
        private System.Windows.Forms.ToolStripButton tsbtrove;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
    }
}