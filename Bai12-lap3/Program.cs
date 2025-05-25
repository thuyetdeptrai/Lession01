using System;

class MaTran
{
    int n, m;
    int[,] a;

    public MaTran() { }
    public MaTran(int n, int m)
    {
        this.n = n; this.m = m;
        a = new int[n, m];
    }

    public void Nhap()
    {
        Console.WriteLine($"Nhập ma trận {n}x{m}:");
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                Console.Write($"a[{i},{j}]= "); a[i, j] = int.Parse(Console.ReadLine());
            }
    }

    public void HienThi()
    {
        for (int i = 0; i < n; i++, Console.WriteLine())
            for (int j = 0; j < m; j++)
                Console.Write($"{a[i, j],5}");
    }

    public MaTran Cong(MaTran b)
    {
        MaTran kq = new MaTran(n, m);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                kq.a[i, j] = a[i, j] + b.a[i, j];
        return kq;
    }

    public MaTran Tru(MaTran b)
    {
        MaTran kq = new MaTran(n, m);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                kq.a[i, j] = a[i, j] - b.a[i, j];
        return kq;
    }

    public MaTran Nhan(MaTran b)
    {
        MaTran kq = new MaTran(n, b.m);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < b.m; j++)
                for (int k = 0; k < m; k++)
                    kq.a[i, j] += a[i, k] * b.a[k, j];
        return kq;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập số dòng: "); int n = int.Parse(Console.ReadLine());
        Console.Write("Nhập số cột: "); int m = int.Parse(Console.ReadLine());

        MaTran A = new MaTran(n, m); A.Nhap();
        MaTran B = new MaTran(n, m); B.Nhap();

        Console.WriteLine("a. Tổng\nb. Hiệu\nc. Tích");
        string chon = Console.ReadLine();
        MaTran kq = chon switch
        {
            "a" => A.Cong(B),
            "b" => A.Tru(B),
            "c" => A.Nhan(B),
            _ => null
        };
        Console.WriteLine("Kết quả:");
        kq?.HienThi();
    }
}
