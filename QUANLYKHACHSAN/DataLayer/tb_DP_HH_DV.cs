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
    
    public partial class tb_DP_HH_DV
    {
        public int MaDP_HH_DV { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<double> ThanhTien { get; set; }
        public Nullable<int> MaPhong { get; set; }
        public Nullable<int> MaDat { get; set; }
        public Nullable<int> MaCT_DP { get; set; }
        public Nullable<int> MaHH_DV { get; set; }
    
        public virtual tb_CT_DP tb_CT_DP { get; set; }
        public virtual tb_hanghoa_dichvu tb_hanghoa_dichvu { get; set; }
    }
}
