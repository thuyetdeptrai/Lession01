using System;

class PhanSo
{
    public int Tu, Mau;
    public PhanSo() { Tu = 0; Mau = 1; }
    public PhanSo(int tu, int mau)
    {
        Tu = tu;
        Mau = mau == 0 ? 1 : mau;
    }

    public void Nhap()
    {
        Console.Write("Tử: "); Tu = int.Parse(Console.ReadLine());
        Console.Write("Mẫu: "); Mau = int.Parse(Console.ReadLine());
    }

    public void Hien() => Console.WriteLine($"{Tu}/{Mau}");

    public void RutGon()
    {
        int a = Math.Abs(Tu), b = Math.Abs(Mau), r;
        while (b != 0) { r = a % b; a = b; b = r; }
        Tu /= a; Mau /= a;
    }

    public PhanSo Cong(PhanSo b) =>
        new PhanSo(Tu * b.Mau + Mau * b.Tu, Mau * b.Mau);
    public PhanSo Tru(PhanSo b) =>
        new PhanSo(Tu * b.Mau - Mau * b.Tu, Mau * b.Mau);
    public PhanSo Nhan(PhanSo b) =>
        new PhanSo(Tu * b.Tu, Mau * b.Mau);
    public PhanSo Chia(PhanSo b) =>
        new PhanSo(Tu * b.Mau, Mau * b.Tu);
}

class Program
{
    static void Main()
    {
        PhanSo a = new PhanSo(), b = new PhanSo();
        Console.WriteLine("Nhập A:"); a.Nhap();
        Console.WriteLine("Nhập B:"); b.Nhap();

        Console.WriteLine("Chọn: 1.Cộng 2.Trừ 3.Nhân 4.Chia");
        int chon = int.Parse(Console.ReadLine());
        PhanSo kq = chon switch
        {
            1 => a.Cong(b),
            2 => a.Tru(b),
            3 => a.Nhan(b),
            4 => a.Chia(b),
            _ => new PhanSo()
        };
        kq.RutGon();
        Console.Write("Kết quả: "); kq.Hien();
    }
}
