namespace KhachSan
{
    partial class Khách_Hàng
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
            this.ckgioitinh = new System.Windows.Forms.CheckBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupControl1.Controls.Add(this.ckgioitinh);
            this.groupControl1.Controls.Add(this.txtmakh);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtsdt);
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txtcccd);
            this.groupControl1.Controls.Add(this.txttenkh);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 302);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(862, 144);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin";
            // 
            // ckgioitinh
            // 
            this.ckgioitinh.AutoSize = true;
            this.ckgioitinh.Location = new System.Drawing.Point(711, 52);
            this.ckgioitinh.Name = "ckgioitinh";
            this.ckgioitinh.Size = new System.Drawing.Size(47, 17);
            this.ckgioitinh.TabIndex = 11;
            this.ckgioitinh.Text = "Nam";
            this.ckgioitinh.UseVisualStyleBackColor = true;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(155, 50);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(66, 21);
            this.txtmakh.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã khách hàng";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(578, 91);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(112, 21);
            this.txtsdt.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(155, 91);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(342, 21);
            this.txtdiachi.TabIndex = 6;
            // 
            // txtcccd
            // 
            this.txtcccd.Location = new System.Drawing.Point(589, 50);
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(107, 21);
            this.txtcccd.TabIndex = 5;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(320, 50);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(201, 21);
            this.txttenkh.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số CCCD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 54);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(862, 257);
            this.gcdanhsach.TabIndex = 6;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKH,
            this.TenKH,
            this.CCCD,
            this.DiaChi,
            this.DienThoai,
            this.GioiTinh});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            this.gvdanhsach.DoubleClick += new System.EventHandler(this.gvdanhsach_DoubleClick);
            // 
            // MaKH
            // 
            this.MaKH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MaKH.AppearanceHeader.Options.UseFont = true;
            this.MaKH.Caption = "MÃ KH";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.MaxWidth = 65;
            this.MaKH.MinWidth = 55;
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 0;
            this.MaKH.Width = 62;
            // 
            // TenKH
            // 
            this.TenKH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TenKH.AppearanceHeader.Options.UseFont = true;
            this.TenKH.Caption = "TÊN KHÁCH HÀNG";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.MaxWidth = 180;
            this.TenKH.MinWidth = 160;
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 1;
            this.TenKH.Width = 180;
            // 
            // CCCD
            // 
            this.CCCD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.CCCD.AppearanceHeader.Options.UseFont = true;
            this.CCCD.Caption = "Số CCCD";
            this.CCCD.FieldName = "CCCD";
            this.CCCD.MaxWidth = 140;
            this.CCCD.MinWidth = 100;
            this.CCCD.Name = "CCCD";
            this.CCCD.Visible = true;
            this.CCCD.VisibleIndex = 2;
            this.CCCD.Width = 126;
            // 
            // DiaChi
            // 
            this.DiaChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DiaChi.AppearanceHeader.Options.UseFont = true;
            this.DiaChi.Caption = "ĐỊA CHỈ ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MaxWidth = 250;
            this.DiaChi.MinWidth = 260;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 4;
            this.DiaChi.Width = 260;
            // 
            // DienThoai
            // 
            this.DienThoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DienThoai.AppearanceHeader.Options.UseFont = true;
            this.DienThoai.Caption = "ĐIỆN THOẠI";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.MaxWidth = 110;
            this.DienThoai.MinWidth = 100;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 5;
            this.DienThoai.Width = 110;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GioiTinh.AppearanceHeader.Options.UseFont = true;
            this.GioiTinh.Caption = "GIỚI TÍNH";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.MaxWidth = 80;
            this.GioiTinh.MinWidth = 70;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 3;
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
            this.toolStrip1.Size = new System.Drawing.Size(862, 54);
            this.toolStrip1.TabIndex = 5;
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
            this.tsbthoat.Image = global::KhachSan.Properties.Resources.istockphoto_1050831532_612x612;
            this.tsbthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthoat.Name = "tsbthoat";
            this.tsbthoat.Size = new System.Drawing.Size(41, 51);
            this.tsbthoat.Text = "Thoát";
            this.tsbthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbthoat.Click += new System.EventHandler(this.tsbthoat_Click);
            // 
            // Khách_Hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 446);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcdanhsach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Khách_Hàng";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.Khách_hàng_Load);
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
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbthem;
        private System.Windows.Forms.ToolStripButton tsbxoa;
        private System.Windows.Forms.ToolStripButton tsbsua;
        private System.Windows.Forms.ToolStripButton tsbluu;
        private System.Windows.Forms.ToolStripButton tsbtrove;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn CCCD;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private System.Windows.Forms.CheckBox ckgioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
    }
}