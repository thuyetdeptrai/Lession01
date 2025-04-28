using System;
using System.Collections.Generic;

class HoiVien
{
    public string HoTen, DiaChi;
    public virtual void Nhap()
    {
        Console.Write("Nhập họ tên: "); HoTen = Console.ReadLine();
        Console.Write("Nhập địa chỉ: "); DiaChi = Console.ReadLine();
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Địa chỉ: {DiaChi}");
    }

    public virtual bool LaNgayCuoi11_11_2011() => false;
    public virtual bool DaCoNguoiYeuNhungChuaCuoi() => false;
}

class DaCuoi : HoiVien
{
    public string TenVoChong;
    public DateTime NgayCuoi;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập tên vợ/chồng: "); TenVoChong = Console.ReadLine();
        Console.Write("Nhập ngày cưới (dd/MM/yyyy): ");
        NgayCuoi = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Đã kết hôn với: {TenVoChong}, Ngày cưới: {NgayCuoi.ToString("dd/MM/yyyy")}");
    }

    public override bool LaNgayCuoi11_11_2011() => NgayCuoi == new DateTime(2011, 11, 11);
}

class DaCoNguoiYeu : HoiVien
{
    public string TenNguoiYeu, SDTNguoiYeu;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập tên người yêu: "); TenNguoiYeu = Console.ReadLine();
        Console.Write("Nhập số điện thoại người yêu: "); SDTNguoiYeu = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Người yêu: {TenNguoiYeu}, SĐT: {SDTNguoiYeu}");
    }

    public override bool DaCoNguoiYeuNhungChuaCuoi() => true;
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập số hội viên: ");
        int n = int.Parse(Console.ReadLine());
        List<HoiVien> ds = new List<HoiVien>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nChọn loại hội viên:");
            Console.WriteLine("1. Đã có gia đình");
            Console.WriteLine("2. Có người yêu");
            Console.WriteLine("3. Độc thân");
            int chon = int.Parse(Console.ReadLine());

            HoiVien hv;
            switch (chon)
            {
                case 1: hv = new DaCuoi(); break;
                case 2: hv = new DaCoNguoiYeu(); break;
                default: hv = new HoiVien(); break;
            }

            hv.Nhap();
            ds.Add(hv);
        }

        Console.WriteLine("\n📅 Hội viên có ngày cưới là 11/11/2011:");
        foreach (var hv in ds)
            if (hv.LaNgayCuoi11_11_2011())
                hv.HienThi();

        Console.WriteLine("\n❤️ Hội viên có người yêu nhưng chưa lập gia đình:");
        foreach (var hv in ds)
            if (hv.DaCoNguoiYeuNhungChuaCuoi())
                hv.HienThi();
    }
}
