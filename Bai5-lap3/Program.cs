using System;
using System.Collections.Generic;

class Nguoi
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string SoCMND { get; set; }

    public Nguoi(string hoTen, int namSinh, string soCMND)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        SoCMND = soCMND;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, CMND: {SoCMND}");
    }
}

class KhachSan
{
    public int SoNgayTro { get; set; }
    public string LoaiPhong { get; set; }
    public double GiaPhong { get; set; }
    public Nguoi Khach { get; set; }

    public KhachSan(int soNgayTro, string loaiPhong, double giaPhong, Nguoi khach)
    {
        SoNgayTro = soNgayTro;
        LoaiPhong = loaiPhong;
        GiaPhong = giaPhong;
        Khach = khach;
    }

    public double TinhTien()
    {
        return SoNgayTro * GiaPhong;
    }

    public void HienThiThongTin()
    {
        Khach.HienThiThongTin();
        Console.WriteLine($"Số ngày trọ: {SoNgayTro}, Loại phòng: {LoaiPhong}, Giá phòng: {GiaPhong}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<KhachSan> khachSans = new List<KhachSan>();
        Console.Write("Nhập số khách trọ: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin khách trọ {i + 1}:");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());
            Console.Write("Số CMND: ");
            string soCMND = Console.ReadLine();

            Nguoi nguoi = new Nguoi(hoTen, namSinh, soCMND);

            Console.Write("Số ngày trọ: ");
            int soNgayTro = int.Parse(Console.ReadLine());
            Console.Write("Loại phòng: ");
            string loaiPhong = Console.ReadLine();
            Console.Write("Giá phòng: ");
            double giaPhong = double.Parse(Console.ReadLine());

            KhachSan khachSan = new KhachSan(soNgayTro, loaiPhong, giaPhong, nguoi);
            khachSans.Add(khachSan);
        }

        Console.WriteLine("\nThông tin khách trọ:");
        foreach (var khach in khachSans)
        {
            khach.HienThiThongTin();
            Console.WriteLine($"Tiền thanh toán: {khach.TinhTien()} VND");
        }

        // Tìm kiếm theo họ tên
        Console.Write("\nNhập họ tên khách trọ cần tìm: ");
        string hoTenCanTim = Console.ReadLine();
        foreach (var khach in khachSans)
        {
            if (khach.Khach.HoTen.Equals(hoTenCanTim, StringComparison.OrdinalIgnoreCase))
            {
                khach.HienThiThongTin();
            }
        }
    }
}
