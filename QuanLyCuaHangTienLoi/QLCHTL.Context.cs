﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ca> Cas { get; set; }
        public virtual DbSet<ChamCong> ChamCongs { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NgayLe> NgayLes { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<PhanCong> PhanCongs { get; set; }
        public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TinhLuong> TinhLuongs { get; set; }
        public virtual DbSet<ChiTietHoaDonThanhToan> ChiTietHoaDonThanhToans { get; set; }
        public virtual DbSet<NhanVienConLamViec> NhanVienConLamViecs { get; set; }
        public virtual DbSet<NhanVienNghiLam> NhanVienNghiLams { get; set; }
        public virtual DbSet<SanPhamConBan> SanPhamConBans { get; set; }
        public virtual DbSet<SPConHan> SPConHans { get; set; }
        public virtual DbSet<SPHetHan> SPHetHans { get; set; }
        public virtual DbSet<ViewKho> ViewKhoes { get; set; }
        public virtual DbSet<XemBangPC_NhanVien> XemBangPC_NhanVien { get; set; }
    
        [DbFunction("Entities", "BangChiTietHoaDonThanhToan")]
        public virtual IQueryable<BangChiTietHoaDonThanhToan_Result> BangChiTietHoaDonThanhToan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<BangChiTietHoaDonThanhToan_Result>("[Entities].[BangChiTietHoaDonThanhToan]()");
        }
    
        [DbFunction("Entities", "LocDoanhThu")]
        public virtual IQueryable<LocDoanhThu_Result> LocDoanhThu(Nullable<System.DateTime> ngaybatdau, Nullable<System.DateTime> ngayketthuc)
        {
            var ngaybatdauParameter = ngaybatdau.HasValue ?
                new ObjectParameter("ngaybatdau", ngaybatdau) :
                new ObjectParameter("ngaybatdau", typeof(System.DateTime));
    
            var ngayketthucParameter = ngayketthuc.HasValue ?
                new ObjectParameter("ngayketthuc", ngayketthuc) :
                new ObjectParameter("ngayketthuc", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<LocDoanhThu_Result>("[Entities].[LocDoanhThu](@ngaybatdau, @ngayketthuc)", ngaybatdauParameter, ngayketthucParameter);
        }
    
        public virtual int sp_NhapKho(Nullable<int> masp, Nullable<System.DateTime> nsx, Nullable<System.DateTime> hsd, Nullable<System.DateTime> ngaynhapkho, Nullable<bool> loaikho, Nullable<int> sltonkho)
        {
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var nsxParameter = nsx.HasValue ?
                new ObjectParameter("nsx", nsx) :
                new ObjectParameter("nsx", typeof(System.DateTime));
    
            var hsdParameter = hsd.HasValue ?
                new ObjectParameter("hsd", hsd) :
                new ObjectParameter("hsd", typeof(System.DateTime));
    
            var ngaynhapkhoParameter = ngaynhapkho.HasValue ?
                new ObjectParameter("ngaynhapkho", ngaynhapkho) :
                new ObjectParameter("ngaynhapkho", typeof(System.DateTime));
    
            var loaikhoParameter = loaikho.HasValue ?
                new ObjectParameter("loaikho", loaikho) :
                new ObjectParameter("loaikho", typeof(bool));
    
            var sltonkhoParameter = sltonkho.HasValue ?
                new ObjectParameter("sltonkho", sltonkho) :
                new ObjectParameter("sltonkho", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_NhapKho", maspParameter, nsxParameter, hsdParameter, ngaynhapkhoParameter, loaikhoParameter, sltonkhoParameter);
        }
    
        public virtual int sp_SuaCa(string maca, Nullable<int> loaica, Nullable<System.TimeSpan> giobatdau, Nullable<System.TimeSpan> gioketthuc)
        {
            var macaParameter = maca != null ?
                new ObjectParameter("maca", maca) :
                new ObjectParameter("maca", typeof(string));
    
            var loaicaParameter = loaica.HasValue ?
                new ObjectParameter("loaica", loaica) :
                new ObjectParameter("loaica", typeof(int));
    
            var giobatdauParameter = giobatdau.HasValue ?
                new ObjectParameter("giobatdau", giobatdau) :
                new ObjectParameter("giobatdau", typeof(System.TimeSpan));
    
            var gioketthucParameter = gioketthuc.HasValue ?
                new ObjectParameter("gioketthuc", gioketthuc) :
                new ObjectParameter("gioketthuc", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaCa", macaParameter, loaicaParameter, giobatdauParameter, gioketthucParameter);
        }
    
        public virtual int sp_SuaChamCong(Nullable<int> mapc, Nullable<System.TimeSpan> giobd, Nullable<System.TimeSpan> giokt, Nullable<double> luong)
        {
            var mapcParameter = mapc.HasValue ?
                new ObjectParameter("mapc", mapc) :
                new ObjectParameter("mapc", typeof(int));
    
            var giobdParameter = giobd.HasValue ?
                new ObjectParameter("giobd", giobd) :
                new ObjectParameter("giobd", typeof(System.TimeSpan));
    
            var gioktParameter = giokt.HasValue ?
                new ObjectParameter("giokt", giokt) :
                new ObjectParameter("giokt", typeof(System.TimeSpan));
    
            var luongParameter = luong.HasValue ?
                new ObjectParameter("luong", luong) :
                new ObjectParameter("luong", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaChamCong", mapcParameter, giobdParameter, gioktParameter, luongParameter);
        }
    
        public virtual int sp_SuaChiTietHoaDon(Nullable<int> mahd, Nullable<int> masp, Nullable<System.DateTime> nsx, Nullable<System.DateTime> hsd, Nullable<int> sl)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var nsxParameter = nsx.HasValue ?
                new ObjectParameter("nsx", nsx) :
                new ObjectParameter("nsx", typeof(System.DateTime));
    
            var hsdParameter = hsd.HasValue ?
                new ObjectParameter("hsd", hsd) :
                new ObjectParameter("hsd", typeof(System.DateTime));
    
            var slParameter = sl.HasValue ?
                new ObjectParameter("sl", sl) :
                new ObjectParameter("sl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaChiTietHoaDon", mahdParameter, maspParameter, nsxParameter, hsdParameter, slParameter);
        }
    
        public virtual int sp_SuaHoaDon(Nullable<int> mahd, string manv, string sdtkh, Nullable<int> pttt)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var sdtkhParameter = sdtkh != null ?
                new ObjectParameter("sdtkh", sdtkh) :
                new ObjectParameter("sdtkh", typeof(string));
    
            var ptttParameter = pttt.HasValue ?
                new ObjectParameter("pttt", pttt) :
                new ObjectParameter("pttt", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaHoaDon", mahdParameter, manvParameter, sdtkhParameter, ptttParameter);
        }
    
        public virtual int sp_SuaKhachHang(string sdt, string tenkh, Nullable<int> diemtichluy)
        {
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var diemtichluyParameter = diemtichluy.HasValue ?
                new ObjectParameter("diemtichluy", diemtichluy) :
                new ObjectParameter("diemtichluy", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaKhachHang", sdtParameter, tenkhParameter, diemtichluyParameter);
        }
    
        public virtual int sp_SuaLSP(Nullable<int> maloai, string tenloai)
        {
            var maloaiParameter = maloai.HasValue ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(int));
    
            var tenloaiParameter = tenloai != null ?
                new ObjectParameter("tenloai", tenloai) :
                new ObjectParameter("tenloai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaLSP", maloaiParameter, tenloaiParameter);
        }
    
        public virtual int sp_SuaNgayLe(Nullable<int> mangayle, string sukien, Nullable<System.DateTime> ngay)
        {
            var mangayleParameter = mangayle.HasValue ?
                new ObjectParameter("mangayle", mangayle) :
                new ObjectParameter("mangayle", typeof(int));
    
            var sukienParameter = sukien != null ?
                new ObjectParameter("sukien", sukien) :
                new ObjectParameter("sukien", typeof(string));
    
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaNgayLe", mangayleParameter, sukienParameter, ngayParameter);
        }
    
        public virtual int sp_SuaNhanVien(string manv, string tennv, string sdt, string phai, Nullable<System.DateTime> ngaysinh, string email, string macv, string trangthai, string tentk, string matkhau)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var phaiParameter = phai != null ?
                new ObjectParameter("phai", phai) :
                new ObjectParameter("phai", typeof(string));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(System.DateTime));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var macvParameter = macv != null ?
                new ObjectParameter("macv", macv) :
                new ObjectParameter("macv", typeof(string));
    
            var trangthaiParameter = trangthai != null ?
                new ObjectParameter("trangthai", trangthai) :
                new ObjectParameter("trangthai", typeof(string));
    
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaNhanVien", manvParameter, tennvParameter, sdtParameter, phaiParameter, ngaysinhParameter, emailParameter, macvParameter, trangthaiParameter, tentkParameter, matkhauParameter);
        }
    
        public virtual int sp_SuaNhaSanXuat(Nullable<int> mansx, string tennsx, string diachi)
        {
            var mansxParameter = mansx.HasValue ?
                new ObjectParameter("mansx", mansx) :
                new ObjectParameter("mansx", typeof(int));
    
            var tennsxParameter = tennsx != null ?
                new ObjectParameter("tennsx", tennsx) :
                new ObjectParameter("tennsx", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaNhaSanXuat", mansxParameter, tennsxParameter, diachiParameter);
        }
    
        public virtual int sp_SuaPhanCong(Nullable<int> mapc, string manv, string maca, Nullable<System.DateTime> ngaydangky)
        {
            var mapcParameter = mapc.HasValue ?
                new ObjectParameter("mapc", mapc) :
                new ObjectParameter("mapc", typeof(int));
    
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var macaParameter = maca != null ?
                new ObjectParameter("maca", maca) :
                new ObjectParameter("maca", typeof(string));
    
            var ngaydangkyParameter = ngaydangky.HasValue ?
                new ObjectParameter("ngaydangky", ngaydangky) :
                new ObjectParameter("ngaydangky", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaPhanCong", mapcParameter, manvParameter, macaParameter, ngaydangkyParameter);
        }
    
        public virtual int sp_SuaSanPham(Nullable<int> masp, string tensp, string mansx, string maloai, Nullable<double> giaban, Nullable<double> giagoc, string trangthai)
        {
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var mansxParameter = mansx != null ?
                new ObjectParameter("mansx", mansx) :
                new ObjectParameter("mansx", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var giabanParameter = giaban.HasValue ?
                new ObjectParameter("giaban", giaban) :
                new ObjectParameter("giaban", typeof(double));
    
            var giagocParameter = giagoc.HasValue ?
                new ObjectParameter("giagoc", giagoc) :
                new ObjectParameter("giagoc", typeof(double));
    
            var trangthaiParameter = trangthai != null ?
                new ObjectParameter("trangthai", trangthai) :
                new ObjectParameter("trangthai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaSanPham", maspParameter, tenspParameter, mansxParameter, maloaiParameter, giabanParameter, giagocParameter, trangthaiParameter);
        }
    
        public virtual int sp_SuaSpVaoKho(Nullable<int> masp, Nullable<System.DateTime> nsx, Nullable<System.DateTime> hsd, Nullable<System.DateTime> ngaynhapkho, Nullable<bool> loaikho, Nullable<int> sltonkho)
        {
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var nsxParameter = nsx.HasValue ?
                new ObjectParameter("nsx", nsx) :
                new ObjectParameter("nsx", typeof(System.DateTime));
    
            var hsdParameter = hsd.HasValue ?
                new ObjectParameter("hsd", hsd) :
                new ObjectParameter("hsd", typeof(System.DateTime));
    
            var ngaynhapkhoParameter = ngaynhapkho.HasValue ?
                new ObjectParameter("ngaynhapkho", ngaynhapkho) :
                new ObjectParameter("ngaynhapkho", typeof(System.DateTime));
    
            var loaikhoParameter = loaikho.HasValue ?
                new ObjectParameter("loaikho", loaikho) :
                new ObjectParameter("loaikho", typeof(bool));
    
            var sltonkhoParameter = sltonkho.HasValue ?
                new ObjectParameter("sltonkho", sltonkho) :
                new ObjectParameter("sltonkho", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SuaSpVaoKho", maspParameter, nsxParameter, hsdParameter, ngaynhapkhoParameter, loaikhoParameter, sltonkhoParameter);
        }
    
        public virtual int sp_ThemCa(string maca, Nullable<int> loaica, Nullable<System.TimeSpan> giobatdau, Nullable<System.TimeSpan> gioketthuc)
        {
            var macaParameter = maca != null ?
                new ObjectParameter("maca", maca) :
                new ObjectParameter("maca", typeof(string));
    
            var loaicaParameter = loaica.HasValue ?
                new ObjectParameter("loaica", loaica) :
                new ObjectParameter("loaica", typeof(int));
    
            var giobatdauParameter = giobatdau.HasValue ?
                new ObjectParameter("giobatdau", giobatdau) :
                new ObjectParameter("giobatdau", typeof(System.TimeSpan));
    
            var gioketthucParameter = gioketthuc.HasValue ?
                new ObjectParameter("gioketthuc", gioketthuc) :
                new ObjectParameter("gioketthuc", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemCa", macaParameter, loaicaParameter, giobatdauParameter, gioketthucParameter);
        }
    
        public virtual int sp_ThemChiTietHoaDon(Nullable<int> mahd, Nullable<int> masp, Nullable<System.DateTime> nsx, Nullable<System.DateTime> hsd, Nullable<int> sl)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var nsxParameter = nsx.HasValue ?
                new ObjectParameter("nsx", nsx) :
                new ObjectParameter("nsx", typeof(System.DateTime));
    
            var hsdParameter = hsd.HasValue ?
                new ObjectParameter("hsd", hsd) :
                new ObjectParameter("hsd", typeof(System.DateTime));
    
            var slParameter = sl.HasValue ?
                new ObjectParameter("sl", sl) :
                new ObjectParameter("sl", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemChiTietHoaDon", mahdParameter, maspParameter, nsxParameter, hsdParameter, slParameter);
        }
    
        public virtual int sp_ThemHoaDon(string manv, string sdtkh, Nullable<int> pttt)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var sdtkhParameter = sdtkh != null ?
                new ObjectParameter("sdtkh", sdtkh) :
                new ObjectParameter("sdtkh", typeof(string));
    
            var ptttParameter = pttt.HasValue ?
                new ObjectParameter("pttt", pttt) :
                new ObjectParameter("pttt", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemHoaDon", manvParameter, sdtkhParameter, ptttParameter);
        }
    
        public virtual int sp_ThemKhachHang(string sdt, string tenkh, Nullable<double> diemtichluy)
        {
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var diemtichluyParameter = diemtichluy.HasValue ?
                new ObjectParameter("diemtichluy", diemtichluy) :
                new ObjectParameter("diemtichluy", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemKhachHang", sdtParameter, tenkhParameter, diemtichluyParameter);
        }
    
        public virtual int sp_ThemLSP(string tenloai)
        {
            var tenloaiParameter = tenloai != null ?
                new ObjectParameter("tenloai", tenloai) :
                new ObjectParameter("tenloai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemLSP", tenloaiParameter);
        }
    
        public virtual int sp_ThemNgayLe(Nullable<int> mangayle, string sukien, Nullable<System.DateTime> ngay)
        {
            var mangayleParameter = mangayle.HasValue ?
                new ObjectParameter("mangayle", mangayle) :
                new ObjectParameter("mangayle", typeof(int));
    
            var sukienParameter = sukien != null ?
                new ObjectParameter("sukien", sukien) :
                new ObjectParameter("sukien", typeof(string));
    
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemNgayLe", mangayleParameter, sukienParameter, ngayParameter);
        }
    
        public virtual int sp_ThemNhanVien(string tennv, string sdt, string phai, Nullable<System.DateTime> ngaysinh, string email, string macv, string trangthai, string tentk, string matkhau)
        {
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var phaiParameter = phai != null ?
                new ObjectParameter("phai", phai) :
                new ObjectParameter("phai", typeof(string));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(System.DateTime));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var macvParameter = macv != null ?
                new ObjectParameter("macv", macv) :
                new ObjectParameter("macv", typeof(string));
    
            var trangthaiParameter = trangthai != null ?
                new ObjectParameter("trangthai", trangthai) :
                new ObjectParameter("trangthai", typeof(string));
    
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemNhanVien", tennvParameter, sdtParameter, phaiParameter, ngaysinhParameter, emailParameter, macvParameter, trangthaiParameter, tentkParameter, matkhauParameter);
        }
    
        public virtual int sp_ThemNhaSanXuat(string tennsx, string diachi)
        {
            var tennsxParameter = tennsx != null ?
                new ObjectParameter("tennsx", tennsx) :
                new ObjectParameter("tennsx", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemNhaSanXuat", tennsxParameter, diachiParameter);
        }
    
        public virtual int sp_ThemPhanCong(string manv, string maca, Nullable<System.DateTime> ngaydangky)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var macaParameter = maca != null ?
                new ObjectParameter("maca", maca) :
                new ObjectParameter("maca", typeof(string));
    
            var ngaydangkyParameter = ngaydangky.HasValue ?
                new ObjectParameter("ngaydangky", ngaydangky) :
                new ObjectParameter("ngaydangky", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemPhanCong", manvParameter, macaParameter, ngaydangkyParameter);
        }
    
        public virtual int sp_ThemSanPham(string tensp, string mansx, string maloai, Nullable<double> giaban, Nullable<double> giagoc, string trangthai)
        {
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var mansxParameter = mansx != null ?
                new ObjectParameter("mansx", mansx) :
                new ObjectParameter("mansx", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var giabanParameter = giaban.HasValue ?
                new ObjectParameter("giaban", giaban) :
                new ObjectParameter("giaban", typeof(double));
    
            var giagocParameter = giagoc.HasValue ?
                new ObjectParameter("giagoc", giagoc) :
                new ObjectParameter("giagoc", typeof(double));
    
            var trangthaiParameter = trangthai != null ?
                new ObjectParameter("trangthai", trangthai) :
                new ObjectParameter("trangthai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ThemSanPham", tenspParameter, mansxParameter, maloaiParameter, giabanParameter, giagocParameter, trangthaiParameter);
        }
    
        public virtual int sp_TraKho(Nullable<int> masp, Nullable<System.DateTime> nsx, Nullable<System.DateTime> hsd, Nullable<System.DateTime> ngayxuatkho, Nullable<int> soluong)
        {
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var nsxParameter = nsx.HasValue ?
                new ObjectParameter("nsx", nsx) :
                new ObjectParameter("nsx", typeof(System.DateTime));
    
            var hsdParameter = hsd.HasValue ?
                new ObjectParameter("hsd", hsd) :
                new ObjectParameter("hsd", typeof(System.DateTime));
    
            var ngayxuatkhoParameter = ngayxuatkho.HasValue ?
                new ObjectParameter("ngayxuatkho", ngayxuatkho) :
                new ObjectParameter("ngayxuatkho", typeof(System.DateTime));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_TraKho", maspParameter, nsxParameter, hsdParameter, ngayxuatkhoParameter, soluongParameter);
        }
    
        public virtual int sp_XoaCa(string maca, Nullable<int> loaica, Nullable<System.TimeSpan> giobatdau, Nullable<System.TimeSpan> gioketthuc)
        {
            var macaParameter = maca != null ?
                new ObjectParameter("maca", maca) :
                new ObjectParameter("maca", typeof(string));
    
            var loaicaParameter = loaica.HasValue ?
                new ObjectParameter("loaica", loaica) :
                new ObjectParameter("loaica", typeof(int));
    
            var giobatdauParameter = giobatdau.HasValue ?
                new ObjectParameter("giobatdau", giobatdau) :
                new ObjectParameter("giobatdau", typeof(System.TimeSpan));
    
            var gioketthucParameter = gioketthuc.HasValue ?
                new ObjectParameter("gioketthuc", gioketthuc) :
                new ObjectParameter("gioketthuc", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaCa", macaParameter, loaicaParameter, giobatdauParameter, gioketthucParameter);
        }
    
        public virtual int sp_XoaChamCong(Nullable<int> mapc)
        {
            var mapcParameter = mapc.HasValue ?
                new ObjectParameter("mapc", mapc) :
                new ObjectParameter("mapc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaChamCong", mapcParameter);
        }
    
        public virtual int sp_XoaChiTietHoaDon(Nullable<int> mahd, Nullable<int> masp, Nullable<System.DateTime> nsx, Nullable<System.DateTime> hsd)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var nsxParameter = nsx.HasValue ?
                new ObjectParameter("nsx", nsx) :
                new ObjectParameter("nsx", typeof(System.DateTime));
    
            var hsdParameter = hsd.HasValue ?
                new ObjectParameter("hsd", hsd) :
                new ObjectParameter("hsd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaChiTietHoaDon", mahdParameter, maspParameter, nsxParameter, hsdParameter);
        }
    
        public virtual int sp_XoaHoaDon(Nullable<int> mahd)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaHoaDon", mahdParameter);
        }
    
        public virtual int sp_XoaKhachHang(string sdt)
        {
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaKhachHang", sdtParameter);
        }
    
        public virtual int sp_XoaLSP(Nullable<int> maloai)
        {
            var maloaiParameter = maloai.HasValue ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaLSP", maloaiParameter);
        }
    
        public virtual int sp_XoaNgayLe(Nullable<int> mangayle)
        {
            var mangayleParameter = mangayle.HasValue ?
                new ObjectParameter("mangayle", mangayle) :
                new ObjectParameter("mangayle", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaNgayLe", mangayleParameter);
        }
    
        public virtual int sp_XoaNhanVien(string manv)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaNhanVien", manvParameter);
        }
    
        public virtual int sp_XoaNhaSanXuat(Nullable<int> mansx)
        {
            var mansxParameter = mansx.HasValue ?
                new ObjectParameter("mansx", mansx) :
                new ObjectParameter("mansx", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaNhaSanXuat", mansxParameter);
        }
    
        public virtual int sp_XoaPhanCong(Nullable<int> mapc)
        {
            var mapcParameter = mapc.HasValue ?
                new ObjectParameter("mapc", mapc) :
                new ObjectParameter("mapc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaPhanCong", mapcParameter);
        }
    
        public virtual int sp_XoaSanPham(Nullable<int> masp)
        {
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaSanPham", maspParameter);
        }
    
        public virtual int sp_XoaSpVaoKho(Nullable<int> masp, Nullable<System.DateTime> nsx, Nullable<System.DateTime> hsd)
        {
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var nsxParameter = nsx.HasValue ?
                new ObjectParameter("nsx", nsx) :
                new ObjectParameter("nsx", typeof(System.DateTime));
    
            var hsdParameter = hsd.HasValue ?
                new ObjectParameter("hsd", hsd) :
                new ObjectParameter("hsd", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XoaSpVaoKho", maspParameter, nsxParameter, hsdParameter);
        }
    
        public virtual int sp_XuatKho(Nullable<int> masp, Nullable<System.DateTime> nsx, Nullable<System.DateTime> hsd, Nullable<System.DateTime> ngayxuatkho, Nullable<int> soluong)
        {
            var maspParameter = masp.HasValue ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(int));
    
            var nsxParameter = nsx.HasValue ?
                new ObjectParameter("nsx", nsx) :
                new ObjectParameter("nsx", typeof(System.DateTime));
    
            var hsdParameter = hsd.HasValue ?
                new ObjectParameter("hsd", hsd) :
                new ObjectParameter("hsd", typeof(System.DateTime));
    
            var ngayxuatkhoParameter = ngayxuatkho.HasValue ?
                new ObjectParameter("ngayxuatkho", ngayxuatkho) :
                new ObjectParameter("ngayxuatkho", typeof(System.DateTime));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_XuatKho", maspParameter, nsxParameter, hsdParameter, ngayxuatkhoParameter, soluongParameter);
        }
    
        public virtual int UpDateGioBD(Nullable<int> mapc, Nullable<System.TimeSpan> giobd)
        {
            var mapcParameter = mapc.HasValue ?
                new ObjectParameter("mapc", mapc) :
                new ObjectParameter("mapc", typeof(int));
    
            var giobdParameter = giobd.HasValue ?
                new ObjectParameter("giobd", giobd) :
                new ObjectParameter("giobd", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpDateGioBD", mapcParameter, giobdParameter);
        }
    
        public virtual int UpDateGioKT(Nullable<int> mapc, Nullable<System.TimeSpan> giokt)
        {
            var mapcParameter = mapc.HasValue ?
                new ObjectParameter("mapc", mapc) :
                new ObjectParameter("mapc", typeof(int));
    
            var gioktParameter = giokt.HasValue ?
                new ObjectParameter("giokt", giokt) :
                new ObjectParameter("giokt", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpDateGioKT", mapcParameter, gioktParameter);
        }
    
        public virtual ObjectResult<UpdateLaiCuaHangKhiThanhToan_Result> UpdateLaiCuaHangKhiThanhToan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateLaiCuaHangKhiThanhToan_Result>("UpdateLaiCuaHangKhiThanhToan");
        }
    }
}
