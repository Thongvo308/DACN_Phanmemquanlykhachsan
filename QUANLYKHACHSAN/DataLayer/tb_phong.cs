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
    
    public partial class tb_phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_phong()
        {
            this.tb_CT_DP = new HashSet<tb_CT_DP>();
            this.tb_datphong = new HashSet<tb_datphong>();
        }
    
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public Nullable<int> MaLoai { get; set; }
        public Nullable<int> MaTB { get; set; }
        public Nullable<int> SoTang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CT_DP> tb_CT_DP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_datphong> tb_datphong { get; set; }
        public virtual tb_loaiphong tb_loaiphong { get; set; }
        public virtual tb_tang tb_tang { get; set; }
        public virtual tb_thietbi tb_thietbi { get; set; }
    }
}