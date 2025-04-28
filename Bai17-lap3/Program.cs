using System;
using System.Collections.Generic;

class Diem
{
    public double X { get; set; }
    public double Y { get; set; }

    public Diem() { X = 0; Y = 0; }
    public Diem(double x, double y) { X = x; Y = y; }

    public void In()
    {
        Console.WriteLine($"({X}, {Y})");
    }

    public double TinhKhoangCach(Diem b)
    {
        return Math.Sqrt((X - b.X) * (X - b.X) + (Y - b.Y) * (Y - b.Y));
    }
}

class HinhTron
{
    public Diem Tam { get; set; }
    public float BanKinh { get; set; }

    public HinhTron()
    {
        Tam = new Diem();
        BanKinh = 0;
    }

    public HinhTron(Diem tam, float bk)
    {
        Tam = tam;
        BanKinh = bk;
    }

    public double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }

    public bool GiaoNhau(HinhTron h)
    {
        double d = Tam.TinhKhoangCach(h.Tam);
        return d <= (BanKinh + h.BanKinh);
    }

    public void HienThi()
    {
        Console.Write("Tâm: ");
        Tam.In();
        Console.WriteLine($"Bán kính: {BanKinh}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập số lượng hình tròn: ");
        int n = int.Parse(Console.ReadLine());
        List<HinhTron> ds = new List<HinhTron>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập hình tròn thứ {i + 1}: ");
            Console.Write("Nhập hoành độ tâm: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ tâm: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Nhập bán kính: ");
            float bk = float.Parse(Console.ReadLine());

            ds.Add(new HinhTron(new Diem(x, y), bk));
        }

        int maxGiao = 0;
        HinhTron hinhMax = null;

        foreach (var h1 in ds)
        {
            int dem = 0;
            foreach (var h2 in ds)
            {
                if (h1 != h2 && h1.GiaoNhau(h2)) dem++;
            }

            if (dem > maxGiao)
            {
                maxGiao = dem;
                hinhMax = h1;
            }
        }

        Console.WriteLine("\nHình tròn giao với nhiều hình khác nhất:");
        hinhMax?.HienThi();
        Console.WriteLine($"Số lần giao: {maxGiao}");
    }
}

