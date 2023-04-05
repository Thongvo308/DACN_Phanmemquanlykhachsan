namespace KhachSan
{
    partial class FormLoaiPhong
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
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsonguoi = new System.Windows.Forms.TextBox();
            this.txtsogiuong = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvdanhsach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNguoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcdanhsach = new DevExpress.XtraGrid.GridControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(554, 54);
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
            this.tsbtrove.Image = global::KhachSan.Properties.Resources.istockphoto_1050831530_612x612;
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
            this.groupControl1.Controls.Add(this.txtmaloai);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtsonguoi);
            this.groupControl1.Controls.Add(this.txtsogiuong);
            this.groupControl1.Controls.Add(this.txtdongia);
            this.groupControl1.Controls.Add(this.txtten);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 348);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(554, 153);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(117, 54);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(117, 21);
            this.txtmaloai.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Loại";
            // 
            // txtsonguoi
            // 
            this.txtsonguoi.Location = new System.Drawing.Point(437, 92);
            this.txtsonguoi.Name = "txtsonguoi";
            this.txtsonguoi.Size = new System.Drawing.Size(41, 21);
            this.txtsonguoi.TabIndex = 7;
            // 
            // txtsogiuong
            // 
            this.txtsogiuong.Location = new System.Drawing.Point(315, 89);
            this.txtsogiuong.Name = "txtsogiuong";
            this.txtsogiuong.Size = new System.Drawing.Size(43, 21);
            this.txtsogiuong.TabIndex = 6;
            this.txtsogiuong.TextChanged += new System.EventHandler(this.txtsogiuong_TextChanged);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(117, 89);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(117, 21);
            this.txtdongia.TabIndex = 5;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(315, 54);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(163, 21);
            this.txtten.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số giường";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số người";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại";
            // 
            // gvdanhsach
            // 
            this.gvdanhsach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenLoai,
            this.DonGia,
            this.SoGiuong,
            this.SoNguoi,
            this.MaLoaiPhong});
            this.gvdanhsach.GridControl = this.gcdanhsach;
            this.gvdanhsach.Name = "gvdanhsach";
            this.gvdanhsach.OptionsView.ShowGroupPanel = false;
            this.gvdanhsach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvdanhsach_CustomDrawCell);
            this.gvdanhsach.Click += new System.EventHandler(this.gvdanhsach_Click);
            // 
            // TenLoai
            // 
            this.TenLoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TenLoai.AppearanceHeader.Options.UseFont = true;
            this.TenLoai.Caption = "TÊN LOẠI";
            this.TenLoai.FieldName = "TenLoai";
            this.TenLoai.MaxWidth = 100;
            this.TenLoai.MinWidth = 80;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Visible = true;
            this.TenLoai.VisibleIndex = 1;
            this.TenLoai.Width = 80;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DonGia.AppearanceHeader.Options.UseFont = true;
            this.DonGia.Caption = "ĐƠN GIÁ";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.MaxWidth = 150;
            this.DonGia.MinWidth = 130;
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            this.DonGia.Width = 130;
            // 
            // SoGiuong
            // 
            this.SoGiuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SoGiuong.AppearanceHeader.Options.UseFont = true;
            this.SoGiuong.Caption = "SỐ GIƯỜNG";
            this.SoGiuong.FieldName = "SoGiuong";
            this.SoGiuong.MaxWidth = 80;
            this.SoGiuong.MinWidth = 60;
            this.SoGiuong.Name = "SoGiuong";
            this.SoGiuong.Visible = true;
            this.SoGiuong.VisibleIndex = 3;
            this.SoGiuong.Width = 70;
            // 
            // SoNguoi
            // 
            this.SoNguoi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SoNguoi.AppearanceHeader.Options.UseFont = true;
            this.SoNguoi.Caption = "SỐ NGƯỜI";
            this.SoNguoi.FieldName = "SoNguoi";
            this.SoNguoi.MaxWidth = 80;
            this.SoNguoi.MinWidth = 60;
            this.SoNguoi.Name = "SoNguoi";
            this.SoNguoi.Visible = true;
            this.SoNguoi.VisibleIndex = 4;
            this.SoNguoi.Width = 70;
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MaLoaiPhong.AppearanceHeader.Options.UseFont = true;
            this.MaLoaiPhong.Caption = "MÃ LOẠI";
            this.MaLoaiPhong.FieldName = "MaLoai";
            this.MaLoaiPhong.MaxWidth = 70;
            this.MaLoaiPhong.MinWidth = 50;
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            this.MaLoaiPhong.Visible = true;
            this.MaLoaiPhong.VisibleIndex = 0;
            this.MaLoaiPhong.Width = 50;
            // 
            // gcdanhsach
            // 
            this.gcdanhsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcdanhsach.Location = new System.Drawing.Point(0, 54);
            this.gcdanhsach.MainView = this.gvdanhsach;
            this.gcdanhsach.Name = "gcdanhsach";
            this.gcdanhsach.Size = new System.Drawing.Size(554, 297);
            this.gcdanhsach.TabIndex = 3;
            this.gcdanhsach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvdanhsach});
            // 
            // FormLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 501);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcdanhsach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormLoaiPhong";
            this.Text = "Loại Phòng";
            this.Load += new System.EventHandler(this.FormLoaiPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdanhsach)).EndInit();
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
        private System.Windows.Forms.TextBox txtsonguoi;
        private System.Windows.Forms.TextBox txtsogiuong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbtrove;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoai;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoNguoi;
        private DevExpress.XtraGrid.GridControl gcdanhsach;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiPhong;
    }
}