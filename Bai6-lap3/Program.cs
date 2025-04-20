using System;
using System.Collections.Generic;

class Nguoi
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public int NamSinh { get; set; }
    public string QueQuan { get; set; }
    public string GioiTinh { get; set; }

    public Nguoi(string hoTen, int tuoi, int namSinh, string queQuan, string gioiTinh)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
        NamSinh = namSinh;
        QueQuan = queQuan;
        GioiTinh = gioiTinh;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, Giới tính: {GioiTinh}");
    }
}

class HSHocSinh
{
    public string Lop { get; set; }
    public string KhoaHoc { get; set; }
    public string KyHoc { get; set; }
    public Nguoi HocSinh { get; set; }

    public HSHocSinh(string lop, string khoaHoc, string kyHoc, Nguoi hocSinh)
    {
        Lop = lop;
        KhoaHoc = khoaHoc;
        KyHoc = kyHoc;
        HocSinh = hocSinh;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Lớp: {Lop}, Khoá học: {KhoaHoc}, Kỳ học: {KyHoc}");
        HocSinh.HienThiThongTin();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<HSHocSinh> danhSachHocSinh = new List<HSHocSinh>();
        Console.Write("Nhập số học sinh: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin học sinh {i + 1}:");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());
            Console.Write("Quê quán: ");
            string queQuan = Console.ReadLine();
            Console.Write("Giới tính: ");
            string gioiTinh = Console.ReadLine();

            Nguoi nguoi = new Nguoi(hoTen, tuoi, namSinh, queQuan, gioiTinh);

            Console.Write("Lớp: ");
            string lop = Console.ReadLine();
            Console.Write("Khoá học: ");
            string khoaHoc = Console.ReadLine();
            Console.Write("Kỳ học: ");
            string kyHoc = Console.ReadLine();

            HSHocSinh hocSinh = new HSHocSinh(lop, khoaHoc, kyHoc, nguoi);
            danhSachHocSinh.Add(hocSinh);
        }

        // Hiển thị học sinh nữ và sinh năm 1985
        Console.WriteLine("\nHọc sinh nữ và sinh năm 1985:");
        foreach (var hs in danhSachHocSinh)
        {
            if (hs.HocSinh.GioiTinh == "Nữ" && hs.HocSinh.NamSinh == 1985)
            {
                hs.HienThiThongTin();
            }
        }

        // Tìm kiếm theo quê quán
        Console.Write("\nNhập quê quán cần tìm: ");
        string queQuanCanTim = Console.ReadLine();
        foreach (var hs in danhSachHocSinh)
        {
            if (hs.HocSinh.QueQuan.Equals(queQuanCanTim, StringComparison.OrdinalIgnoreCase))
            {
                hs.HienThiThongTin();
            }
        }
    }
}

