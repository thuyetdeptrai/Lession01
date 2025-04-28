using System;
using System.Collections.Generic;

abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}

class HinhTron : Hinh
{
    public double BanKinh { get; set; }

    public HinhTron(double banKinh)
    {
        BanKinh = banKinh;
    }

    public override double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public override double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }
}

class HinhVuong : Hinh
{
    public double Canh { get; set; }

    public HinhVuong(double canh)
    {
        Canh = canh;
    }

    public override double TinhChuVi()
    {
        return 4 * Canh;
    }

    public override double TinhDienTich()
    {
        return Canh * Canh;
    }
}

class HinhTamGiac : Hinh
{
    public double Canh1 { get; set; }
    public double Canh2 { get; set; }
    public double Canh3 { get; set; }

    public HinhTamGiac(double canh1, double canh2, double canh3)
    {
        Canh1 = canh1;
        Canh2 = canh2;
        Canh3 = canh3;
    }

    public override double TinhChuVi()
    {
        return Canh1 + Canh2 + Canh3;
    }

    public override double TinhDienTich()
    {
        // Áp dụng công thức Heron
        double p = (Canh1 + Canh2 + Canh3) / 2;
        return Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
    }
}

class HinhChuNhat : Hinh
{
    public double ChieuDai { get; set; }
    public double ChieuRong { get; set; }

    public HinhChuNhat(double chieuDai, double chieuRong)
    {
        ChieuDai = chieuDai;
        ChieuRong = chieuRong;
    }

    public override double TinhChuVi()
    {
        return 2 * (ChieuDai + ChieuRong);
    }

    public override double TinhDienTich()
    {
        return ChieuDai * ChieuRong;
    }
}

class Program
{
    static void Main()
    {
        List<Hinh> danhSachHinh = new List<Hinh>();

        // Thêm các hình vào danh sách
        danhSachHinh.Add(new HinhTron(5));
        danhSachHinh.Add(new HinhVuong(4));
        danhSachHinh.Add(new HinhTamGiac(3, 4, 5));
        danhSachHinh.Add(new HinhChuNhat(6, 8));

        double tongChuVi = 0, tongDienTich = 0;

        // Tính tổng chu vi và diện tích
        foreach (var h in danhSachHinh)
        {
            tongChuVi += h.TinhChuVi();
            tongDienTich += h.TinhDienTich();
        }

        // Hiển thị kết quả
        Console.WriteLine($"Tổng chu vi của các hình: {tongChuVi}");
        Console.WriteLine($"Tổng diện tích của các hình: {tongDienTich}");
    }
}
