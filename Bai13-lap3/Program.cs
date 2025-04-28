using System;
using System.Collections.Generic;

class PTGT
{
    public string Hang, Mau;
    public int Nam;
    public double Gia;
    public PTGT(string hang, int nam, double gia, string mau)
    {
        Hang = hang; Nam = nam; Gia = gia; Mau = mau;
    }
    public virtual void Show() =>
        Console.WriteLine($"Hãng:{Hang}, Năm:{Nam}, Giá:{Gia}, Màu:{Mau}");
}

class OTo : PTGT
{
    public int Cho; public string DongCo;
    public OTo(string h, int n, double g, string m, int c, string d) : base(h, n, g, m)
    {
        Cho = c; DongCo = d;
    }
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Chỗ:{Cho}, Động cơ:{DongCo}");
    }
}

class XeMay : PTGT
{
    public double CongSuat;
    public XeMay(string h, int n, double g, string m, double cs) : base(h, n, g, m)
    {
        CongSuat = cs;
    }
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Công suất:{CongSuat}");
    }
}

class XeTai : PTGT
{
    public double TrongTai;
    public XeTai(string h, int n, double g, string m, double tt) : base(h, n, g, m)
    {
        TrongTai = tt;
    }
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Trọng tải:{TrongTai}");
    }
}

class QLPTGT
{
    List<PTGT> ds = new List<PTGT>();
    public void Nhap()
    {
        Console.Write("Loại (oto/may/tai): "); var loai = Console.ReadLine();
        Console.Write("Hãng: "); var h = Console.ReadLine();
        Console.Write("Năm: "); int n = int.Parse(Console.ReadLine());
        Console.Write("Giá: "); double g = double.Parse(Console.ReadLine());
        Console.Write("Màu: "); var m = Console.ReadLine();

        if (loai == "oto")
        {
            Console.Write("Chỗ: "); int c = int.Parse(Console.ReadLine());
            Console.Write("Động cơ: "); string d = Console.ReadLine();
            ds.Add(new OTo(h, n, g, m, c, d));
        }
        else if (loai == "may")
        {
            Console.Write("Công suất: "); double cs = double.Parse(Console.ReadLine());
            ds.Add(new XeMay(h, n, g, m, cs));
        }
        else if (loai == "tai")
        {
            Console.Write("Trọng tải: "); double tt = double.Parse(Console.ReadLine());
            ds.Add(new XeTai(h, n, g, m, tt));
        }
    }

    public void Tim()
    {
        Console.Write("Tìm theo (mau/nam): "); var k = Console.ReadLine();
        Console.Write("Giá trị: "); var v = Console.ReadLine();
        foreach (var x in ds)
            if ((k == "mau" && x.Mau == v) || (k == "nam" && x.Nam.ToString() == v))
                x.Show();
    }

    public void Menu()
    {
        int chon;
        do
        {
            Console.WriteLine("\n1.Nhập 2.Tìm 0.Thoát"); chon = int.Parse(Console.ReadLine());
            if (chon == 1) Nhap();
            else if (chon == 2) Tim();
        } while (chon != 0);
    }
}

class Program
{
    static void Main() => new QLPTGT().Menu();
}
