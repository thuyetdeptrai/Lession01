using System;

class SoPhuc
{
    public double PhanThuc, PhanAo;

    public SoPhuc() { }
    public SoPhuc(double a, double b) => (PhanThuc, PhanAo) = (a, b);

    public void Nhap()
    {
        Console.Write("Phần thực: "); PhanThuc = double.Parse(Console.ReadLine());
        Console.Write("Phần ảo: "); PhanAo = double.Parse(Console.ReadLine());
    }

    public void HienThi() => Console.WriteLine($"{PhanThuc} + {PhanAo}i");

    public SoPhuc Cong(SoPhuc b) => new SoPhuc(PhanThuc + b.PhanThuc, PhanAo + b.PhanAo);
    public SoPhuc Tru(SoPhuc b) => new SoPhuc(PhanThuc - b.PhanThuc, PhanAo - b.PhanAo);
    public SoPhuc Nhan(SoPhuc b) =>
        new SoPhuc(PhanThuc * b.PhanThuc - PhanAo * b.PhanAo, PhanThuc * b.PhanAo + PhanAo * b.PhanThuc);
    public SoPhuc Chia(SoPhuc b)
    {
        double mau = b.PhanThuc * b.PhanThuc + b.PhanAo * b.PhanAo;
        return new SoPhuc(
            (PhanThuc * b.PhanThuc + PhanAo * b.PhanAo) / mau,
            (PhanAo * b.PhanThuc - PhanThuc * b.PhanAo) / mau
        );
    }
}

class Program
{
    static void Main()
    {
        SoPhuc A = new SoPhuc(), B = new SoPhuc();
        Console.WriteLine("Nhập số phức A:"); A.Nhap();
        Console.WriteLine("Nhập số phức B:"); B.Nhap();

        Console.WriteLine("a. Cộng\nb. Hiệu\nc. Tích\nd. Thương");
        string chon = Console.ReadLine();
        SoPhuc kq = chon switch
        {
            "a" => A.Cong(B),
            "b" => A.Tru(B),
            "c" => A.Nhan(B),
            "d" => A.Chia(B),
            _ => null
        };
        Console.Write("Kết quả: "); kq?.HienThi();
    }
}
