//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_datphong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_datphong()
        {
            this.tb_CT_DP = new HashSet<tb_CT_DP>();
        }
    
        public int MaDat { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public Nullable<int> SoNguoiO { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public Nullable<double> SoTien { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> MaPhong { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<int> MaNV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CT_DP> tb_CT_DP { get; set; }
        public virtual tb_khachhang tb_khachhang { get; set; }
        public virtual tb_nhanvien tb_nhanvien { get; set; }
        public virtual tb_phong tb_phong { get; set; }
    }
}
