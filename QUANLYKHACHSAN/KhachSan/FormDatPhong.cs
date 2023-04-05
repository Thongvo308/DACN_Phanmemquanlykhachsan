using BusinessLayer;
using DataLayer;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.Utils.Gesture;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.DragEngine;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraRichEdit.Import.Doc;
using KhachSan.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DevExpress.XtraExport;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace KhachSan
{
    public partial class FormDatPhong : DevExpress.XtraEditors.XtraForm
    {
        public FormDatPhong()
        {
            InitializeComponent();
            DataTable data =  myFunctions.laydulieu("select A.MaPhong,A.TenPhong, C.DonGia, A.SoTang, B.TenTang from tb_phong A, tb_tang B,tb_loaiphong C where A.SoTang = B.SoTang and A.TrangThai = 0 and A.MaLoai = C.MaLoai");
            gcp.DataSource = data;
            gcdsdatphong.DataSource = data.Clone();
        }

        FormQLChung objQLchung = (FormQLChung)Application.OpenForms["FormQLChung"];

        public bool _them;
        int _maphong = 0;
        string _tenphong;
        int _maDP = 0;
        int _rowDP=0;

        Phong _phong;
        DatPhong _datphong;
        KhachHang _khachhang;
        HangHoa_DichVu _hanghoa_dichvu;
        GridHitInfo downHitInfor = null;
        List<OBJ_DP_DV> lstDP_DV;
        ChiTiet_DatPhong _chitiet_datphong;
        DatPhong_HH_DV _datphong_hhdv;
        OBJ_DatPhong _objdp;

        private void Đặt_phòng_Load(object sender, EventArgs e)
        {
            
            _khachhang = new KhachHang();
            _hanghoa_dichvu = new HangHoa_DichVu();
            _datphong = new DatPhong();
            _chitiet_datphong = new ChiTiet_DatPhong();
            _phong = new Phong();
            _datphong_hhdv = new DatPhong_HH_DV();
            tabdanhsach.SelectedTabPage = pagedanhsach;
            dtdenngay.Value = DateTime.Now;
            dttungay.Value =  myFunctions.GetFirstDayInMont(DateTime.Now.Year, DateTime.Now.Month);
            cbott.DataSource = TRANGTHAI.getList();
            cbott.ValueMember = "value";
            cbott.DisplayMember = "display";
            lstDP_DV = new List<OBJ_DP_DV>();
            txtthanhtien.Enabled = false;
            loadHH_DV();
            loadKH();
            loadDanhsach();
            gvp.ExpandAllGroups();
            showHideControl(true);
            enable(false);
        }
   
  
        public void loadKH()
        {
            _khachhang = new KhachHang();
            cbokh.DataSource = _khachhang.getAll();
            cbokh.DisplayMember = "TenKH";
            cbokh.ValueMember = "MaKH";
        }

        void loadHH_DV()
        {
            _hanghoa_dichvu = new HangHoa_DichVu();
            gcdv.DataSource = _hanghoa_dichvu.getList();
            gvdv.OptionsBehavior.Editable=false;
        }
        void showHideControl(bool t)
        {
            btnthem.Visible = t;
            btnsua.Visible = t;
            btnxoa.Visible = t;
            btnluu.Visible = !t;
            btnin.Visible = t;
            btntrove.Visible = !t;
            btnthoat.Visible = t;
        }

        void enable(bool t)
        {
            cbokh.Enabled = t;  
            dtngaydat.Enabled = t;
            dtngaytra.Enabled = t;
            cbott.Enabled = t;
            btnthemkh.Enabled = t;
            spsonguoio.Enabled = t;
            gcp.Enabled = t;
            gcdichvu.Enabled = t;
            gcdsdatphong.Enabled = t;
            gcdsdichvu.Enabled = t;
            txtthanhtien.Enabled = t;
        }

        void reset()
        {
            dtngaydat.Value = DateTime.Now;
            dtngaytra.Value = DateTime.Now.AddDays(1);
            cbott.SelectedValue = false;
            txtthanhtien.Text = "0";
            spsonguoio.Text = "1";
        }

        void _addReset()
        {
            DataTable data = myFunctions.laydulieu("select A.MaPhong,A.TenPhong, C.DonGia, A.SoTang, B.TenTang from tb_phong A, tb_tang B,tb_loaiphong C where A.SoTang = B.SoTang and A.TrangThai = 0 and A.MaLoai = C.MaLoai");
            gcp.DataSource = data;
            gcdsdatphong.DataSource = data.Clone();
            gvp.ExpandAllGroups();
            gcdsdichvu.DataSource = _datphong_hhdv.getAllByDatPhong(0);
            txtthanhtien.Text = "0";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            enable(true);
            tabdanhsach.SelectedTabPage = pagechitiet;
            reset();
            _addReset();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _datphong.delete(_maDP);
                var lstP = _chitiet_datphong.getByDatPhong(_maDP);
                foreach(var item in lstP)
                {
                    _phong.updateStatus(item.MaPhong, false);
                }
            }
            loadDanhsach();
            objQLchung.glcontrol.Gallery.Groups.Clear();    
            objQLchung.showRom();
        }
            
        private void btnsua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(false);
            enable(true);
            tabdanhsach.SelectedTabPage = pagechitiet;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            saveData();
            loadDanhsach();
            objQLchung.glcontrol.Gallery.Groups.Clear();
            objQLchung.showRom();
            _them = false;
            enable(false);
            showHideControl(true);
            tabdanhsach.SelectedTabPage = pagedanhsach;

        }
        void saveData()
        {
            if (_them)
            {
                tb_datphong dp = new tb_datphong();
                tb_CT_DP ctdp;
                tb_DP_HH_DV dpdv;
                dp.NgayDat = dtngaydat.Value;
                dp.NgayTra = dtngaytra.Value;
                dp.SoNguoiO = int.Parse(spsonguoio.EditValue.ToString());
                dp.MaPhong = int.Parse(gvdsdatphong.GetFocusedRowCellValue("MaPhong").ToString());
                dp.MaKH = int.Parse(cbokh.SelectedValue.ToString());
                dp.TrangThai = bool.Parse(cbott.SelectedValue.ToString());
                dp.SoTien = double.Parse(txtthanhtien.Text.ToString());
                var _dp = _datphong.add(dp);
                _maDP = _dp.MaDat;
                for (int i = 0; i < gvdsdatphong.RowCount; i++)
                {
                    ctdp = new tb_CT_DP();
                    ctdp.MaDat = _dp.MaDat;
                    ctdp.MaPhong = int.Parse(gvdsdatphong.GetRowCellValue(i, "MaPhong").ToString());
                    ctdp.SoNgayO = dtngaytra.Value.Day - dtngaydat.Value.Day;
                    ctdp.DonGia = double.Parse(gvdsdatphong.GetRowCellValue(i, "DonGia").ToString());
                    ctdp.ThanhTien = ctdp.SoNgayO * ctdp.DonGia;
                     var _ctdp=_chitiet_datphong.add(ctdp);
                    _phong.updateStatus(ctdp.MaPhong, true);

                    if (gvdsdichvu.RowCount > 0)
                    {
                        for (int j = 0; j < gvdsdichvu.RowCount; j++)
                        {
                            if (ctdp.MaPhong == int.Parse(gvdsdichvu.GetRowCellValue(j, "MaPhong").ToString()))
                            {
                                dpdv = new tb_DP_HH_DV();
                                dpdv.MaDat = _dp.MaDat;
                                dpdv.MaCT_DP = _ctdp.MaCT_DP;
                                dpdv.MaPhong = int.Parse(gvdsdichvu.GetRowCellValue(j, "MaPhong").ToString());
                                dpdv.MaHH_DV = int.Parse(gvdsdichvu.GetRowCellValue(j, "MaHH_DV").ToString());
                                dpdv.SoLuong = int.Parse(gvdsdichvu.GetRowCellValue(j, "SoLuong").ToString());
                                dpdv.DonGia = double.Parse(gvdsdichvu.GetRowCellValue(j, "DonGia").ToString());
                                dpdv.ThanhTien = dpdv.SoLuong * dpdv.DonGia;
                                _datphong_hhdv.add(dpdv);
                            }
                         
                        }
                    }
                  
                }
            }

            else
            {
                tb_datphong dp = _datphong.getItem(_maDP);
                tb_CT_DP ctdp;
                tb_DP_HH_DV dpdv;
                dp.NgayDat = dtngaydat.Value;
                dp.NgayTra = dtngaytra.Value;
                dp.SoNguoiO = int.Parse(spsonguoio.EditValue.ToString());
                dp.MaKH = int.Parse(cbokh.SelectedValue.ToString());
                dp.TrangThai = bool.Parse(cbott.SelectedValue.ToString());
                dp.SoTien = double.Parse(txtthanhtien.Text.ToString());
                dp.UPDATE_BY = 1;
                dp.UPDATE_DATE = DateTime.Now;
                var _dp = _datphong.update(dp);
                _maDP = _dp.MaDat;
                _chitiet_datphong.deleteAll(_dp.MaDat);
                _datphong_hhdv.deleteAll(_dp.MaDat);
                for (int i = 0; i < gvdsdatphong.RowCount; i++)
                {
                    ctdp = new tb_CT_DP();
                    ctdp.MaDat = _dp.MaDat;
                    ctdp.MaPhong = int.Parse(gvdsdatphong.GetRowCellValue(i, "MaPhong").ToString());
                    ctdp.SoNgayO = dtngaytra.Value.Day - dtngaydat.Value.Day;
                    ctdp.DonGia = double.Parse(gvdsdatphong.GetRowCellValue(i, "DonGia").ToString());
                    ctdp.ThanhTien = ctdp.SoNgayO * ctdp.DonGia;
                    var _ctdp = _chitiet_datphong.add(ctdp);
                    _phong.updateStatus(ctdp.MaPhong, true);

                    if (gvdsdichvu.RowCount > 0)
                    {
                        for (int j = 0; j < gvdsdichvu.RowCount; j++)
                        {
                            if (ctdp.MaPhong == int.Parse(gvdsdichvu.GetRowCellValue(j, "MaPhong").ToString()))
                            {
                                dpdv = new tb_DP_HH_DV();
                                dpdv.MaDat = _dp.MaDat;
                                dpdv.MaCT_DP = _ctdp.MaCT_DP;
                                dpdv.MaPhong = int.Parse(gvdsdichvu.GetRowCellValue(j, "MaPhong").ToString());
                                dpdv.MaHH_DV = int.Parse(gvdsdichvu.GetRowCellValue(j, "MaHH_DV").ToString());
                                dpdv.SoLuong = int.Parse(gvdsdichvu.GetRowCellValue(j, "SoLuong").ToString());
                                dpdv.DonGia = double.Parse(gvdsdichvu.GetRowCellValue(j, "DonGia").ToString());
                                dpdv.ThanhTien = dpdv.SoLuong * dpdv.DonGia;
                                _datphong_hhdv.add(dpdv);
                            }
                        }
                    }
                }
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            reportdatphong report = new reportdatphong();
            DocumentViewer doc = new DocumentViewer();
            report.InitData(_datphong.getList());
            doc.DocumentSource = report;
            report.ShowPreviewDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        private void btntrove_Click(object sender, EventArgs e)
        {
            _them = false;
            enable(false);
            showHideControl(true);
            tabdanhsach.SelectedTabPage = pagedanhsach;
        }

     
        // Kéo thả đặt phòng
        private void gvdatphong_MouseDown(object sender, MouseEventArgs e)
        {
            if (gvdsdatphong.GetFocusedRowCellValue("MaPhong") != null)
            {
               _maphong = int.Parse(gvdsdatphong.GetFocusedRowCellValue("MaPhong").ToString());
               _tenphong = gvdsdatphong.GetFocusedRowCellValue("TenPhong").ToString();
            }
            GridView view = sender as GridView;
            downHitInfor = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if(Control.ModifierKeys != Keys.None) return;
            if(e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                downHitInfor = hitInfo;
            }
        }

        private void gvdatphong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfor != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfor.HitPoint.X - dragSize.Width / 2, downHitInfor.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfor.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfor = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void gvp_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfor = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                downHitInfor = hitInfo;
            }
        }

        private void gvp_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfor !=null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfor.HitPoint.X - dragSize.Width / 2, downHitInfor.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfor.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfor = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void gcp_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable table = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            if(row != null && table!=null && row.Table != table)
            {
                table.ImportRow(row);
                row.Delete();
            }
        }

        private void gcp_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;

            }
        }
        // đánh số row phòng
        bool cal(Int32 Width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < Width ? Width : view.IndicatorWidth;
            return true;
        }
        private void gvp_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvp.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 Width = Convert.ToInt32(size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(Width, gvp); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 Width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(Width, gvp); }));
            }
        }

        private void gvp_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0}:{1}({2} Phòng trống)", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }


        // thêm dịch vụ vào danh sách
          private void gcdv_DoubleClick(object sender, EventArgs e)
          {
                if (_maphong == 0)
                {
                    MessageBox.Show("Vui lòng chọn phòng cần thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (gvdv.GetFocusedRowCellValue("MaHH_DV") != null)
                {
                    OBJ_DP_DV dv = new OBJ_DP_DV();
                    dv.MaHH_DV = int.Parse(gvdv.GetFocusedRowCellValue("MaHH_DV").ToString());
                    dv.TenHH_DV = gvdv.GetFocusedRowCellValue("TenHH_DV").ToString();
                    dv.MaPhong = _maphong;
                    dv.TenPhong = _tenphong;
                    dv.DonGia = float.Parse(gvdv.GetFocusedRowCellValue("DonGia").ToString());
                    dv.SoLuong = 1;
                    dv.ThanhTien = dv.DonGia * dv.SoLuong;
                    foreach (var item in lstDP_DV)
                    {
                        if (item.MaHH_DV == dv.MaHH_DV && item.MaPhong == dv.MaPhong)
                        {
                            item.SoLuong = item.SoLuong + 1;
                            item.ThanhTien = item.SoLuong * item.DonGia;
                            loadDP_DV();
                            return;
                        }
                    }
                    lstDP_DV.Add(dv);
                }
                loadDP_DV();
                txtthanhtien.Text = (double.Parse(gvdsdichvu.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()) + double.Parse(gvdsdatphong.Columns["DonGia"].SummaryItem.SummaryValue.ToString())).ToString("N0");

        }

        void loadDP_DV()
          {
            List<OBJ_DP_DV> lsdp = new List<OBJ_DP_DV>();
            foreach(var item in lstDP_DV)
            {
                lsdp.Add(item);
            }
             gcdsdichvu.DataSource = lsdp;
          }

        //cập nhật giá tiền dịch vụ
        private void gvdsdichvu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
          {
              if (e.Column.FieldName =="SoLuong")
              {
                  int sl = int.Parse(e.Value.ToString());
                  if(sl != 0)
                  {
                      double gia = double.Parse(gvdsdichvu.GetRowCellValue(gvdsdichvu.FocusedRowHandle, "DonGia").ToString());
                      gvdsdichvu.SetRowCellValue(gvdsdichvu.FocusedRowHandle, "ThanhTien", sl * gia);
                  }

                  else
                  {
                      gvdsdichvu.SetRowCellValue(gvdsdichvu.FocusedRowHandle, "ThanhTien", 0);
                  }
              }
            gvdsdichvu.UpdateTotalSummary();
            txtthanhtien.Text = (double.Parse(gvdsdichvu.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()) + double.Parse(gvdsdatphong.Columns["DonGia"].SummaryItem.SummaryValue.ToString())).ToString("N0");
          }
        
        //cập nhật giá tiền phòng
        private void gvdatphong_RowCountChanged(object sender, EventArgs e)
        {
            if(gvdsdatphong.RowCount<_rowDP && _them == false)
            {
                _phong.updateStatus(_maphong, false);   
                _chitiet_datphong.delete(_maDP,_maphong);
                _datphong_hhdv.deleteAllByPhong(_maDP, _maphong);
                objQLchung.glcontrol.Gallery.Groups.Clear();
                objQLchung.showRom();
            }
            double t = 0;
            if (gvdsdichvu.Columns["ThanhTien"].SummaryItem.SummaryValue == null)
                t = 0;
            else
                t = double.Parse(gvdsdichvu.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString());
            txtthanhtien.Text= (double.Parse(gvdsdatphong.Columns["DonGia"].SummaryItem.SummaryValue.ToString())+t).ToString("N0");
        }

        // đánh số row dịch vụ
        private void gvdv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvdv.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 Width = Convert.ToInt32(size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(Width, gvdv); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 Width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(Width, gvdv); }));
            }
        }

        // đánh số row dịch vụ đặt phòng
        private void gvdatphong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvdsdichvu.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 Width = Convert.ToInt32(size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(Width, gvdsdichvu); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 Width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(Width, gvdsdichvu); }));
            }
        }

        // đánh số row đặt phòng_dịch vụ
        private void gvdsdichvu_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvdsdatphong.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 Width = Convert.ToInt32(size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(Width, gvdsdatphong); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 Width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(Width, gvdsdatphong); }));
            }
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            Khách_Hàng kh = new Khách_Hàng();
            kh.ShowDialog();
        }

        public void setkhachhang(int makh)
        {
            var kh = _khachhang.getItem(makh);
            cbokh.SelectedValue = kh.MaKH;
            cbokh.Text=kh.TenKH;
        }


        void loadDanhsach()
        {
            _datphong = new DatPhong();
            gcdanhsach.DataSource = _datphong.getAll(dttungay.Value, dtdenngay.Value.AddDays(1));
            gvdanhsach.OptionsBehavior.Editable = false;

        }

        private void dttungay_ValueChanged(object sender, EventArgs e)
        {
            if (dttungay.Value>dtdenngay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!","Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadDanhsach();
            }
        }

        private void dttungay_Leave(object sender, EventArgs e)
        {
            if (dttungay.Value > dtdenngay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadDanhsach();
            }
        }

        private void dtdenngay_ValueChanged(object sender, EventArgs e)
        {
            if (dttungay.Value > dtdenngay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadDanhsach();
            }
        } 

        private void dtdenngay_Leave(object sender, EventArgs e)
        {
            if (dttungay.Value > dtdenngay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadDanhsach();
            }
        }

        private void gvdanhsach_Click(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _maDP = int.Parse(gvdanhsach.GetFocusedRowCellValue("MaDat").ToString());
                var dp = _datphong.getItem(_maDP);
                cbokh.SelectedValue = dp.MaKH;
                dtngaydat.Value = dp.NgayDat.Value;
                dtngaytra.Value = dp.NgayTra.Value;
                spsonguoio.Text= dp.SoNguoiO.ToString();
                cbott.SelectedValue = dp.TrangThai;
                txtthanhtien.Text = dp.SoTien.ToString();
                loadDP();
                loadDV();
            }
        }

        void loadDP()
        {
            _rowDP = 0;
            gcdsdatphong.DataSource = myFunctions.laydulieu("select A.MaPhong,A.TenPhong, C.DonGia, A.SoTang, B.TenTang from tb_phong A, tb_tang B,tb_loaiphong C, tb_CT_DP D where A.SoTang = B.SoTang and A.MaLoai = C.MaLoai and A.MaPhong = D.MaPhong and D.MaDat = '"+_maDP+"'");
            _rowDP = gvdsdatphong.RowCount;
        }
        void loadDV()
        {
            //_hanghoa_dichvu = new HangHoa_DichVu();
            gcdsdichvu.DataSource=_datphong_hhdv.getAllByDatPhong(_maDP);
        }

        private void gvdanhsach_DoubleClick(object sender, EventArgs e)
        {
            if (gvdanhsach.RowCount > 0)
            {
                _maDP = int.Parse(gvdanhsach.GetFocusedRowCellValue("MaDat").ToString());
                var dp = _datphong.getItem(_maDP);
                cbokh.SelectedValue = dp.MaKH;
                dtngaydat.Value = dp.NgayDat.Value;
                dtngaytra.Value = dp.NgayTra.Value;
                spsonguoio.Text = dp.SoNguoiO.ToString();
                cbott.SelectedValue = dp.TrangThai;
                txtthanhtien.Text = dp.SoTien.ToString();
                loadDP();
                loadDV();
            }
            tabdanhsach.SelectedTabPage = pagechitiet;
        }

        private void gvdanhsach_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gvdanhsach.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 Width = Convert.ToInt32(size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(Width, gvdanhsach); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 Width = Convert.ToInt32(size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(Width, gvdanhsach); }));
            }
        }

        private void dtngaydat_ValueChanged(object sender, EventArgs e)
        {
            if (dtngaydat.Value > dtngaytra.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadDanhsach();
            }
        }

        private void dtngaydat_Leave(object sender, EventArgs e)
        {
            if (dtngaydat.Value > dtngaytra.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadDanhsach();
            }
        }

        private void dtngaytra_ValueChanged(object sender, EventArgs e)
        {
            if (dtngaydat.Value > dtngaytra.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadDanhsach();
            }
        }

        private void dtngaytra_Leave(object sender, EventArgs e)
        {
            if (dtngaydat.Value > dtngaytra.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadDanhsach();
            }
        }
    }
}