using System;
using System.Collections.Generic;

class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo(int tuSo, int mauSo)
    {
        TuSo = tuSo;
        MauSo = mauSo;
    }

    // Phương thức nhập phân số
    public void Nhap()
    {
        Console.Write("Nhập tử số: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhập mẫu số: ");
        MauSo = int.Parse(Console.ReadLine());
    }

    // Hàm cộng 2 phân số
    public static PhanSo Cong(PhanSo ps1, PhanSo ps2)
    {
        int tuSo = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
        int mauSo = ps1.MauSo * ps2.MauSo;
        return new PhanSo(tuSo, mauSo);
    }

    // Hàm tính tổng các phân số trong List
    public static PhanSo TinhTong(List<PhanSo> phanSos)
    {
        PhanSo tong = new PhanSo(0, 1); // Khởi tạo phân số 0/1
        foreach (var ps in phanSos)
        {
            tong = Cong(tong, ps);
        }
        return tong;
    }

    // Phương thức hiển thị phân số
    public void Xuat()
    {
        Console.WriteLine($"{TuSo}/{MauSo}");
    }
}

class Program
{
    static void Main()
    {
        List<PhanSo> phanSos = new List<PhanSo>();
        Console.Write("Nhập số lượng phân số: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập các phân số
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập phân số thứ {i + 1}:");
            PhanSo ps = new PhanSo(0, 1);
            ps.Nhap();
            phanSos.Add(ps);
        }

        // Tính tổng các phân số
        PhanSo tong = PhanSo.TinhTong(phanSos);
        Console.WriteLine("Tổng các phân số là: ");
        tong.Xuat();
    }
}
