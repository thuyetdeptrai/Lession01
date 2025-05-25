using System;

class DaGiac
{
    protected int SoCanh;
    protected int[] DoDaiCanh;

    public DaGiac(int soCanh)
    {
        SoCanh = soCanh;
        DoDaiCanh = new int[soCanh];
    }

    public virtual void Nhap()
    {
        Console.WriteLine($"Nhập độ dài {SoCanh} cạnh:");
        for (int i = 0; i < SoCanh; i++)
        {
            Console.Write($"Cạnh {i + 1}: ");
            DoDaiCanh[i] = int.Parse(Console.ReadLine());
        }
    }

    public virtual int TinhChuVi()
    {
        int chuVi = 0;
        foreach (int canh in DoDaiCanh)
            chuVi += canh;
        return chuVi;
    }

    public virtual void Xuat()
    {
        Console.Write("Các cạnh: ");
        foreach (int canh in DoDaiCanh)
            Console.Write(canh + " ");
        Console.WriteLine();
    }
}

class TamGiac : DaGiac
{
    public TamGiac() : base(3) { }

    public double TinhDienTich()
    {
        double p = TinhChuVi() / 2.0;
        return Math.Sqrt(p * (p - DoDaiCanh[0]) * (p - DoDaiCanh[1]) * (p - DoDaiCanh[2]));
    }

    public bool LaTamGiacPitago()
    {
        Array.Sort(DoDaiCanh);
        return DoDaiCanh[0] * DoDaiCanh[0] + DoDaiCanh[1] * DoDaiCanh[1] == DoDaiCanh[2] * DoDaiCanh[2];
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập số tam giác: ");
        int n = int.Parse(Console.ReadLine());
        TamGiac[] ds = new TamGiac[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nTam giác thứ {i + 1}:");
            ds[i] = new TamGiac();
            ds[i].Nhap();
        }

        Console.WriteLine("\nTam giác thỏa mãn định lý Pitago:");
        foreach (TamGiac tg in ds)
        {
            if (tg.LaTamGiacPitago())
            {
                tg.Xuat();
                Console.WriteLine($"Chu vi: {tg.TinhChuVi()}, Diện tích: {tg.TinhDienTich():F2}");
            }
        }
    }
}
