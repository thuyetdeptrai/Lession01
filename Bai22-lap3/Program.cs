using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class HocSinh
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public double TongDiem { get; set; }

    public void Nhap()
    {
        Console.Write("Họ tên: ");
        HoTen = Console.ReadLine();
        Console.Write("Năm sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Tổng điểm: ");
        TongDiem = double.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine($"{ChuanHoaTen(HoTen),-25} {NamSinh,10} {TongDiem,10}");
    }

    private string ChuanHoaTen(string ten)
    {
        string[] words = ten.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return string.Join(" ", words.Select(w => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(w)));
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<HocSinh> ds = new List<HocSinh>();
        Console.Write("Nhập số học sinh: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nHọc sinh thứ {i + 1}:");
            HocSinh hs = new HocSinh();
            hs.Nhap();
            ds.Add(hs);
        }

        var sapXep = ds.OrderByDescending(h => h.TongDiem).ThenBy(h => h.NamSinh);

        Console.WriteLine("\nDanh sách học sinh đã sắp xếp:");
        Console.WriteLine($"{"Họ tên",-25} {"Năm sinh",10} {"Tổng điểm",10}");
        foreach (var hs in sapXep)
            hs.Xuat();
    }
}
