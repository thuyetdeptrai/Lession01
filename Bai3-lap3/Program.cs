using System;
using System.Collections.Generic;

class ThiSinh
{
    public string SBD, HoTen, DiaChi, UuTien;
    public double[] Diem = new double[3];
    public virtual void Nhap()
    {
        Console.Write("SBD: "); SBD = Console.ReadLine();
        Console.Write("Họ tên: "); HoTen = Console.ReadLine();
        Console.Write("Địa chỉ: "); DiaChi = Console.ReadLine();
        Console.Write("Ưu tiên: "); UuTien = Console.ReadLine();
    }
    public virtual double TongDiem() => 0;
    public virtual void Xuat() =>
        Console.WriteLine($"{SBD} | {HoTen} | {DiaChi} | {UuTien} | Tổng: {TongDiem()}");
}

class KhoiA : ThiSinh
{
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Toán: "); Diem[0] = double.Parse(Console.ReadLine());
        Console.Write("Lý: "); Diem[1] = double.Parse(Console.ReadLine());
        Console.Write("Hóa: "); Diem[2] = double.Parse(Console.ReadLine());
    }
    public override double TongDiem() => Diem[0] + Diem[1] + Diem[2];
}

class KhoiB : ThiSinh
{
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Toán: "); Diem[0] = double.Parse(Console.ReadLine());
        Console.Write("Hóa: "); Diem[1] = double.Parse(Console.ReadLine());
        Console.Write("Sinh: "); Diem[2] = double.Parse(Console.ReadLine());
    }
    public override double TongDiem() => Diem[0] + Diem[1] + Diem[2];
}

class KhoiC : ThiSinh
{
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Văn: "); Diem[0] = double.Parse(Console.ReadLine());
        Console.Write("Sử: "); Diem[1] = double.Parse(Console.ReadLine());
        Console.Write("Địa: "); Diem[2] = double.Parse(Console.ReadLine());
    }
    public override double TongDiem() => Diem[0] + Diem[1] + Diem[2];
}

class Program
{
    static void Main()
    {
        List<ThiSinh> ds = new List<ThiSinh>();
        while (true)
        {
            Console.Write("\n1.Thêm 2.Tìm 3.Trúng tuyển 4.Thoát: "); string c = Console.ReadLine();
            if (c == "1")
            {
                Console.Write("Khối (A/B/C): "); string k = Console.ReadLine().ToUpper();
                ThiSinh ts = k == "A" ? new KhoiA() : k == "B" ? new KhoiB() : new KhoiC();
                ts.Nhap(); ds.Add(ts);
            }
            else if (c == "2")
            {
                Console.Write("Nhập SBD: "); string sbd = Console.ReadLine();
                ds.ForEach(ts => { if (ts.SBD == sbd) ts.Xuat(); });
            }
            else if (c == "3")
            {
                ds.ForEach(ts => {
                    double diem = ts.TongDiem();
                    if ((ts is KhoiA && diem >= 15) ||
                        (ts is KhoiB && diem >= 16) ||
                        (ts is KhoiC && diem >= 13.5))
                        ts.Xuat();
                });
            }
            else break;
        }
    }
}
