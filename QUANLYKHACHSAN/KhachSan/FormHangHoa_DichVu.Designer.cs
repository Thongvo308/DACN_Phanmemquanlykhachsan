namespace KhachSan
{
    partial class FormHangHoa_DichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenhh_dv = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtmahh_dv = new System.Windows.Forms.TextBox();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHH_DV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHH_DV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.toolStrip1.Size = new System.Drawing.Size(526, 54);
            this.toolStrip1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên HH_DV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // txttenhh_dv
            // 
            this.txttenhh_dv.Location = new System.Drawing.Point(132, 94);
            this.txttenhh_dv.Name = "txttenhh_dv";
            this.txttenhh_dv.Size = new System.Drawing.Size(285, 21);
            this.txttenhh_dv.TabIndex = 4;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(302, 53);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(115, 21);
            this.txtdongia.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã HH_DV";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtmahh_dv);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtdongia);
            this.groupControl1.Controls.Add(this.txttenhh_dv);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 287);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(526, 144);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtmahh_dv
            // 
            this.txtmahh_dv.Location = new System.Drawing.Point(132, 53);
            this.txtmahh_dv.Name = "txtmahh_dv";
            this.txtmahh_dv.Size = new System.Drawing.Size(94, 21);
            this.txtmahh_dv.TabIndex = 10;
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 54);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(526, 239);
            this.gcdanhsach.TabIndex = 9;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHH_DV,
            this.TenHH_DV,
            this.DonGia});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
//            this.gvdanhsach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvdanhsach_CustomDrawCell);
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            // 
            // MaHH_DV
            // 
            this.MaHH_DV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MaHH_DV.AppearanceHeader.Options.UseFont = true;
            this.MaHH_DV.Caption = "MÃ HH_DV";
            this.MaHH_DV.FieldName = "MaHH_DV";
            this.MaHH_DV.MaxWidth = 80;
            this.MaHH_DV.MinWidth = 60;
            this.MaHH_DV.Name = "MaHH_DV";
            this.MaHH_DV.Visible = true;
            this.MaHH_DV.VisibleIndex = 0;
            // 
            // TenHH_DV
            // 
            this.TenHH_DV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TenHH_DV.AppearanceHeader.Options.UseFont = true;
            this.TenHH_DV.Caption = "TÊN HH_DV";
            this.TenHH_DV.FieldName = "TenHH_DV";
            this.TenHH_DV.MaxWidth = 250;
            this.TenHH_DV.Name = "TenHH_DV";
            this.TenHH_DV.Visible = true;
            this.TenHH_DV.VisibleIndex = 1;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DonGia.AppearanceHeader.Options.UseFont = true;
            this.DonGia.Caption = "ĐƠN GIÁ";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.MaxWidth = 120;
            this.DonGia.MinWidth = 100;
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            this.DonGia.Width = 100;
            // 
            // FormHangHoa_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 431);
            this.Controls.Add(this.gcdanhsach);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormHangHoa_DichVu";
            this.Text = "Quản lý hàng hoá dịch vụ";
            this.Load += new System.EventHandler(this.FormDichVu_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenhh_dv;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtmahh_dv;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn MaHH_DV;
        private DevExpress.XtraGrid.Columns.GridColumn TenHH_DV;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private System.Windows.Forms.ToolStripButton tsbtrove;
    }
}