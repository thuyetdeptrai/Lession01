using System;
using System.Collections.Generic;
using System.Linq;

class HoTen
{
    public string Ho, TenDem, Ten;
    public HoTen() { }
    public void Nhap()
    {
        Console.Write("Nhập họ: "); Ho = Console.ReadLine();
        Console.Write("Nhập tên đệm: "); TenDem = Console.ReadLine();
        Console.Write("Nhập tên: "); Ten = Console.ReadLine();
    }
    public string HienThi() => $"{Ho} {TenDem} {Ten}";
}

class QueQuan
{
    public string Xa, Huyen, Tinh;
    public void Nhap()
    {
        Console.Write("Nhập xã: "); Xa = Console.ReadLine();
        Console.Write("Nhập huyện: "); Huyen = Console.ReadLine();
        Console.Write("Nhập tỉnh: "); Tinh = Console.ReadLine();
    }
    public string HienThi() => $"{Xa}, {Huyen}, {Tinh}";
}

class Diem
{
    public double Toan, Ly, Hoa;
    public void Nhap()
    {
        Console.Write("Nhập điểm Toán: "); Toan = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Lý: "); Ly = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Hóa: "); Hoa = double.Parse(Console.ReadLine());
    }
    public double Tong() => Toan + Ly + Hoa;
}

class ThiSinh
{
    public HoTen HoTen = new HoTen();
    public QueQuan QueQuan = new QueQuan();
    public Diem Diem = new Diem();
    public string Truong;
    public int Tuoi;
    public string SoBaoDanh;

    public void Nhap()
    {
        Console.WriteLine("--- Nhập thông tin thí sinh ---");
        HoTen.Nhap();
        QueQuan.Nhap();
        Console.Write("Nhập trường: "); Truong = Console.ReadLine();
        Console.Write("Nhập tuổi: "); Tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhập số báo danh: "); SoBaoDanh = Console.ReadLine();
        Diem.Nhap();
    }

    public void HienThi()
    {
        Console.WriteLine($"{HoTen.HienThi(),-20} | {QueQuan.HienThi(),-30} | {SoBaoDanh,-10} | {Diem.Toan,5} | {Diem.Ly,5} | {Diem.Hoa,5}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập số thí sinh: ");
        int n = int.Parse(Console.ReadLine());
        List<ThiSinh> danhSach = new List<ThiSinh>();
        for (int i = 0; i < n; i++)
        {
            var ts = new ThiSinh();
            ts.Nhap();
            danhSach.Add(ts);
        }

        Console.WriteLine("\n🔍 Thí sinh có tổng điểm > 15:");
        foreach (var ts in danhSach.Where(ts => ts.Diem.Tong() > 15))
        {
            ts.HienThi();
        }

        Console.WriteLine("\n📊 Danh sách sắp xếp theo tổng điểm giảm dần:");
        var sortedList = danhSach.OrderByDescending(ts => ts.Diem.Tong()).ToList();
        Console.WriteLine($"{"Họ tên",-20} | {"Quê quán",-30} | {"SBD",-10} | {"Toán",5} | {"Lý",5} | {"Hóa",5}");
        Console.WriteLine(new string('-', 90));
        foreach (var ts in sortedList)
        {
            ts.HienThi();
        }
    }
}
