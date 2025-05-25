using System;
using System.Collections.Generic;
using System.Linq;

class HocSinh
{
    public string HoTen { get; set; }
    public string GioiTinh { get; set; }
    public double Toan { get; set; }
    public double Ly { get; set; }
    public double Hoa { get; set; }
    public double MonPhu { get; set; } // Kỹ thuật hoặc Nữ công

    public void Nhap()
    {
        Console.Write("Họ tên: ");
        HoTen = Console.ReadLine();
        Console.Write("Giới tính (Nam/Nu): ");
        GioiTinh = Console.ReadLine();
        Console.Write("Điểm Toán: ");
        Toan = double.Parse(Console.ReadLine());
        Console.Write("Điểm Lý: ");
        Ly = double.Parse(Console.ReadLine());
        Console.Write("Điểm Hóa: ");
        Hoa = double.Parse(Console.ReadLine());
        if (GioiTinh.ToLower() == "nam")
        {
            Console.Write("Điểm môn Kỹ thuật: ");
        }
        else
        {
            Console.Write("Điểm môn Nữ công: ");
        }
        MonPhu = double.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine($"{HoTen,-25} {GioiTinh,-5} {Toan,5} {Ly,5} {Hoa,5} {MonPhu,8}");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<HocSinh> danhSach = new List<HocSinh>();
        Console.Write("Nhập số học sinh: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập học sinh thứ {i + 1}:");
            HocSinh hs = new HocSinh();
            hs.Nhap();
            danhSach.Add(hs);
        }

        Console.WriteLine("\nCác học sinh nam có điểm kỹ thuật >= 8:");
        foreach (var hs in danhSach)
        {
            if (hs.GioiTinh.ToLower() == "nam" && hs.MonPhu >= 8)
                hs.Xuat();
        }

        Console.WriteLine("\nDanh sách học sinh nam trước, nữ sau:");
        var sapXep = danhSach.OrderBy(h => h.GioiTinh.ToLower() == "nu" ? 1 : 0);
        foreach (var hs in sapXep)
            hs.Xuat();
    }
}

