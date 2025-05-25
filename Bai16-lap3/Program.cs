using System;

class Diem
{
    public double x, y;

    public Diem() { }

    public Diem(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public void Nhap()
    {
        Console.Write("Nhập hoành độ: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Nhập tung độ: ");
        y = double.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.Write($"({x}, {y})");
    }

    public double TinhKhoangCach(Diem b)
    {
        return Math.Sqrt(Math.Pow(x - b.x, 2) + Math.Pow(y - b.y, 2));
    }
}

class TamGiac
{
    Diem A, B, C;

    public TamGiac()
    {
        A = new Diem();
        B = new Diem();
        C = new Diem();
    }

    public void Nhap()
    {
        Console.WriteLine("Nhập điểm A:");
        A.Nhap();
        Console.WriteLine("Nhập điểm B:");
        B.Nhap();
        Console.WriteLine("Nhập điểm C:");
        C.Nhap();
    }

    public double ChuVi()
    {
        return A.TinhKhoangCach(B) + B.TinhKhoangCach(C) + C.TinhKhoangCach(A);
    }

    public double DienTich()
    {
        double a = A.TinhKhoangCach(B);
        double b = B.TinhKhoangCach(C);
        double c = C.TinhKhoangCach(A);
        double p = (a + b + c) / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập số lượng tam giác: ");
        int n = int.Parse(Console.ReadLine());
        TamGiac[] danhSach = new TamGiac[n];
        double tongCV = 0, tongDT = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nTam giác thứ {i + 1}:");
            danhSach[i] = new TamGiac();
            danhSach[i].Nhap();
            tongCV += danhSach[i].ChuVi();
            tongDT += danhSach[i].DienTich();
        }

        Console.WriteLine($"\nTổng chu vi: {tongCV:F2}");
        Console.WriteLine($"Tổng diện tích: {tongDT:F2}");
    }
}
