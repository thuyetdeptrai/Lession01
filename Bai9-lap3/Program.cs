using System;
using System.Collections.Generic;

class KhachHang
{
    public string HoTen, SoNha, MaCongTo;
    public void Nhap()
    {
        Console.Write("Họ tên: "); HoTen = Console.ReadLine();
        Console.Write("Số nhà: "); SoNha = Console.ReadLine();
        Console.Write("Mã công tơ: "); MaCongTo = Console.ReadLine();
    }
    public void HienThi() => Console.WriteLine($"Họ tên: {HoTen}, Số nhà: {SoNha}, Mã CT: {MaCongTo}");
}

class BienLai
{
    public KhachHang KH = new KhachHang();
    public int ChiSoCu, ChiSoMoi;
    public int TienDien()
    {
        int so = ChiSoMoi - ChiSoCu;
        if (so <= 50) return so * 1250;
        else if (so < 100) return 50 * 1250 + (so - 50) * 1500;
        return 50 * 1250 + 50 * 1500 + (so - 100) * 2000;
    }
    public void Nhap()
    {
        KH.Nhap();
        Console.Write("Chỉ số cũ: "); ChiSoCu = int.Parse(Console.ReadLine());
        Console.Write("Chỉ số mới: "); ChiSoMoi = int.Parse(Console.ReadLine());
    }
    public void HienThi()
    {
        KH.HienThi();
        Console.WriteLine($"Chỉ số cũ: {ChiSoCu}, mới: {ChiSoMoi}, Tiền: {TienDien()} VNĐ\n");
    }
}

class Program
{
    static void Main()
    {
        List<BienLai> list = new();
        Console.Write("Nhập số hộ dân: "); int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"-- Hộ {i + 1} --"); BienLai b = new(); b.Nhap(); list.Add(b);
        }
        Console.WriteLine("\nDanh sách biên lai:");
        foreach (var b in list) b.HienThi();
    }
}
