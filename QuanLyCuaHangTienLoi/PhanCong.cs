//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCuaHangTienLoi
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhanCong
    {
        public int MaPC { get; set; }
        public string MaNV { get; set; }
        public string MaCa { get; set; }
        public System.DateTime NgayDangKy { get; set; }
    
        public virtual Ca Ca { get; set; }
        public virtual ChamCong ChamCong { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}