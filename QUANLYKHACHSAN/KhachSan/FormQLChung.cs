using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
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
    public partial class FormQLChung : DevExpress.XtraEditors.XtraForm
    {
        //phân quyền
        Tang _tang;
        FUNC _func;
        Phong _phong;
        HangHoa_DichVu _hh_dv;
        int _maphong;
        public bool _them;
        List<OBJ_Phong> objphong;



        string tendn = "", tennv = "", matkhau = "", quyen = "";

        public FormQLChung(string tendn, string tennv, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendn = tendn;
            this.tennv = tennv;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }


        private void FormQLChung_Load(object sender, EventArgs e)
        {
            if (quyen == "user")
            {
                btnnhanvien.Enabled = false;
            }
            else
            {
                btnnhanvien.Enabled = true;
            }
            _hh_dv = new HangHoa_DichVu();
            _phong = new Phong();
            _tang = new Tang();
            _func = new FUNC();
            objphong = new List<OBJ_Phong>();
            leftMenu();
            showRom();
            
        }

        void leftMenu()
        {
            var lsParent = _func.getParent();
            foreach(var l in lsParent)
            {
                NavBarGroup navGroup = new NavBarGroup(l.Description);
                navGroup.Tag = l.Func_Code;
                navGroup.Name = l.Func_Code;
                navGroup.ImageOptions.LargeImageIndex = 0;
                navMain.Groups.Add(navGroup);
                var lsChild = _func.getChild(l.Func_Code);
                foreach(var ch in lsChild)
                {
                    NavBarItem navItem = new NavBarItem(ch.Description);
                    navItem.Tag = ch.Func_Code;
                    navItem.Name = ch.Func_Code;
                    navItem.ImageOptions.SmallImageIndex = 0;
                    navGroup.ItemLinks.Add(navItem);
                }
                navMain.Groups[navGroup.Name].Expanded = true;
             }
        }

        public void showRom()
        {
            _tang = new Tang();
            _phong = new Phong();
            var lsTang = _tang.getList();
            glcontrol.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            glcontrol.Gallery.ImageSize = new Size(64,64);
            glcontrol.Gallery.ShowItemText = true;
            glcontrol.Gallery.ShowGroupCaption = true;
            foreach(var t in lsTang)
            {
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = t.TenTang;
                galleryItem.CaptionAlignment   = GalleryItemGroupCaptionAlignment.Stretch;
                var lsPhong = _phong.getByTang(t.SoTang);
                foreach(var p in lsPhong)
                {
                    var gc_item = new GalleryItem();
                    gc_item.Caption = p.TenPhong;
                    gc_item.Value = p.SoTang;
                    galleryItem.Items.Add(gc_item);
                    if (p.TrangThai == true)
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[0];
                    }
                    else
                    {
                        gc_item.ImageOptions.Image = imageList3.Images[1];
                    }
                }
                glcontrol.Gallery.Groups.Add(galleryItem);
            }
            
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
                Nhân_viên nv = new Nhân_viên();
                nv.Show();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            Khách_Hàng kh = new Khách_Hàng();
            kh.ShowDialog();
        }

        private void btnnhacungcap_Click(object sender, EventArgs e)
        {
            Nhà_cung_cấp ncc = new Nhà_cung_cấp();
            ncc.ShowDialog();
        }

 
        private void popupMenu1_Popup(object sender, EventArgs e)
        {
           /* Point point = glcontrol.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = glcontrol.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
                item = hitInfo.GalleryItem;*/
        }

        private void btndatphongdon_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDatPhongDon _dphong = new FormDatPhongDon();
            // _dphong._maphong = int.Parse(galleryItem.Value.ToString());
            _dphong.ShowDialog();

        }

        private void btnthanhtoan_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*if (!_phong.check(int.Parse(item.Value.ToString()))){
             MessageBox.Show("Phòng trống cho nên không thể thanh toán. Vui lòng chọn phòng đã được thuê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             return;
         }
         FormDatPhongDon _datphong = new FormDatPhongDon();
         _datphong._maphong = int.Parse(item.Value.ToString());
         _datphong.ShowDialog();*/
        }

        private void navMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string func_code = e.Link.Item.Tag.ToString();
            switch (func_code)
            {
                case "DATPHONG":
                    {
                        FormDatPhong frm = new FormDatPhong();
                        frm.ShowDialog();
                        break;
                    }
                case "LOAIPHONG":
                    {
                        FormLoaiPhong frm = new FormLoaiPhong();
                        frm.ShowDialog();
                        break;
                    }
                case "DICHVU":
                    {
                        FormHangHoa_DichVu frm = new FormHangHoa_DichVu();
                        frm.ShowDialog();
                        break;
                    }
                case "THIETBI":
                    {
                        FormThietBi frm = new FormThietBi();
                        frm.ShowDialog();
                        break;
                    }

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void glcontrol_Click(object sender, EventArgs e)
        {

        }
    }
}