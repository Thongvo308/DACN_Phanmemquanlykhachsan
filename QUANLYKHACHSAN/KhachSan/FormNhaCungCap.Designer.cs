namespace KhachSan
{
    partial class Nhà_cung_cấp
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbthem = new System.Windows.Forms.ToolStripButton();
            this.tsbxoa = new System.Windows.Forms.ToolStripButton();
            this.tsbsua = new System.Windows.Forms.ToolStripButton();
            this.tsbluu = new System.Windows.Forms.ToolStripButton();
            this.tsbtrove = new System.Windows.Forms.ToolStripButton();
            this.tsbthoat = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(765, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtsdt);
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txttenncc);
            this.groupControl1.Controls.Add(this.txtmancc);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 287);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(765, 144);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Thông tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã NCC";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(550, 91);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(112, 21);
            this.txtsdt.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(117, 94);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(333, 21);
            this.txtdiachi.TabIndex = 6;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(286, 50);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(376, 21);
            this.txttenncc.TabIndex = 5;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(117, 50);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(73, 21);
            this.txtmancc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên NCC";
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 54);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(765, 257);
            this.gcdanhsach.TabIndex = 8;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.DienThoai});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            this.gvdanhsach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvdanhsach_CustomDrawCell);
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            // 
            // MaNCC
            // 
            this.MaNCC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MaNCC.AppearanceHeader.Options.UseFont = true;
            this.MaNCC.Caption = "MÃ NCC";
            this.MaNCC.FieldName = "MaNCC";
            this.MaNCC.MaxWidth = 70;
            this.MaNCC.MinWidth = 60;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Visible = true;
            this.MaNCC.VisibleIndex = 0;
            this.MaNCC.Width = 60;
            // 
            // TenNCC
            // 
            this.TenNCC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TenNCC.AppearanceHeader.Options.UseFont = true;
            this.TenNCC.Caption = "TÊN NHÀ CUNG CẤP";
            this.TenNCC.FieldName = "TenNCC";
            this.TenNCC.MaxWidth = 250;
            this.TenNCC.MinWidth = 240;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Visible = true;
            this.TenNCC.VisibleIndex = 1;
            this.TenNCC.Width = 240;
            // 
            // DiaChi
            // 
            this.DiaChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DiaChi.AppearanceHeader.Options.UseFont = true;
            this.DiaChi.Caption = "ĐỊA CHỈ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MaxWidth = 270;
            this.DiaChi.MinWidth = 260;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            this.DiaChi.Width = 270;
            // 
            // DienThoai
            // 
            this.DienThoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DienThoai.AppearanceHeader.Options.UseFont = true;
            this.DienThoai.Caption = "SỐ ĐIỆN THOẠI";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.MaxWidth = 100;
            this.DienThoai.MinWidth = 90;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 3;
            this.DienThoai.Width = 99;
            // 
            // Nhà_cung_cấp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 431);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcdanhsach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Nhà_cung_cấp";
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.Nhà_cung_cấp_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbthem;
        private System.Windows.Forms.ToolStripButton tsbxoa;
        private System.Windows.Forms.ToolStripButton tsbsua;
        private System.Windows.Forms.ToolStripButton tsbluu;
        private System.Windows.Forms.ToolStripButton tsbthoat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn MaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn TenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private System.Windows.Forms.ToolStripButton tsbtrove;
    }
}