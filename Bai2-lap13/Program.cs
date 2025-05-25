using System;
using System.Collections.Generic;

// Lớp cơ sở
class TaiLieu
{
    public string MaTaiLieu { get; set; }
    public string TenNhaXuatBan { get; set; }
    public int SoBanPhatHanh { get; set; }

    public virtual void Nhap()
    {
        Console.Write("Mã tài liệu: ");
        MaTaiLieu = Console.ReadLine();
        Console.Write("Tên nhà xuất bản: ");
        TenNhaXuatBan = Console.ReadLine();
        Console.Write("Số bản phát hành: ");
        SoBanPhatHanh = int.Parse(Console.ReadLine());
    }

    public virtual void Xuat()
    {
        Console.WriteLine($"Mã: {MaTaiLieu}, NXB: {TenNhaXuatBan}, Số bản phát hành: {SoBanPhatHanh}");
    }

    public virtual string Loai() => "TaiLieu";
}

// Lớp Sách
class Sach : TaiLieu
{
    public string TenTacGia { get; set; }
    public int SoTrang { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Tên tác giả: ");
        TenTacGia = Console.ReadLine();
        Console.Write("Số trang: ");
        SoTrang = int.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Tác giả: {TenTacGia}, Số trang: {SoTrang}");
    }

    public override string Loai() => "Sach";
}

// Lớp Tạp chí
class TapChi : TaiLieu
{
    public int SoPhatHanh { get; set; }
    public int ThangPhatHanh { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Số phát hành: ");
        SoPhatHanh = int.Parse(Console.ReadLine());
        Console.Write("Tháng phát hành: ");
        ThangPhatHanh = int.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Số phát hành: {SoPhatHanh}, Tháng: {ThangPhatHanh}");
    }

    public override string Loai() => "TapChi";
}

// Lớp Báo
class Bao : TaiLieu
{
    public string NgayPhatHanh { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Ngày phát hành (dd/MM/yyyy): ");
        NgayPhatHanh = Console.ReadLine();
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Ngày phát hành: {NgayPhatHanh}");
    }

    public override string Loai() => "Bao";
}

// Lớp quản lý tài liệu
class QuanLyTaiLieu
{
    private List<TaiLieu> danhSach = new List<TaiLieu>();

    public void NhapTaiLieu()
    {
        Console.WriteLine("\nChọn loại tài liệu:");
        Console.WriteLine("1. Sách");
        Console.WriteLine("2. Tạp chí");
        Console.WriteLine("3. Báo");
        Console.Write("Chọn (1-3): ");
        int loai = int.Parse(Console.ReadLine());

        TaiLieu tl = null;
        switch (loai)
        {
            case 1: tl = new Sach(); break;
            case 2: tl = new TapChi(); break;
            case 3: tl = new Bao(); break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ."); return;
        }

        Console.WriteLine("Nhập thông tin:");
        tl.Nhap();
        danhSach.Add(tl);
        Console.WriteLine("==> Đã thêm tài liệu.");
    }

    public void HienThiTatCa()
    {
        Console.WriteLine("\n--- DANH SÁCH TÀI LIỆU ---");
        foreach (var tl in danhSach)
        {
            Console.WriteLine($"\nLoại: {tl.Loai()}");
            tl.Xuat();
        }
    }

    public void TimTheoLoai()
    {
        Console.Write("\nNhập loại cần tìm (Sach/TapChi/Bao): ");
        string loai = Console.ReadLine();

        Console.WriteLine($"\n--- TÀI LIỆU THUỘC LOẠI: {loai} ---");
        foreach (var tl in danhSach)
        {
            if (tl.Loai().Equals(loai, StringComparison.OrdinalIgnoreCase))
            {
                tl.Xuat();
                Console.WriteLine();
            }
        }
    }
}

class Program
{
    static void Main()
    {
        QuanLyTaiLieu ql = new QuanLyTaiLieu();
        int chon;

        do
        {
            Console.WriteLine("\n========= MENU =========");
            Console.WriteLine("1. Thêm tài liệu");
            Console.WriteLine("2. Hiển thị tất cả tài liệu");
            Console.WriteLine("3. Tìm kiếm tài liệu theo loại");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1: ql.NhapTaiLieu(); break;
                case 2: ql.HienThiTatCa(); break;
                case 3: ql.TimTheoLoai(); break;
                case 4: Console.WriteLine("Đã thoát."); break;
                default: Console.WriteLine("Chọn sai, thử lại!"); break;
            }

        } while (chon != 4);
    }
}
