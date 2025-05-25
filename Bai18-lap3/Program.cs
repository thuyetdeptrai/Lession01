using System;
using System.Collections.Generic;

class Nguoi
{
    public string HoTen { get; set; }
    public bool GioiTinh { get; set; }
    public int Tuoi { get; set; }

    public Nguoi() { }

    public Nguoi(string hoTen, bool gioiTinh, int tuoi)
    {
        HoTen = hoTen;
        GioiTinh = gioiTinh;
        Tuoi = tuoi;
    }

    public virtual void In()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Giới tính: {(GioiTinh ? "Nam" : "Nữ")}, Tuổi: {Tuoi}");
    }
}

class CoQuan : Nguoi
{
    public string DonVi { get; set; }
    public double HeSoLuong { get; set; }
    const double LUONG_CO_BAN = 1050000;

    public CoQuan() { }

    public CoQuan(string hoTen, bool gioiTinh, int tuoi, string donVi, double heSoLuong)
        : base(hoTen, gioiTinh, tuoi)
    {
        DonVi = donVi;
        HeSoLuong = heSoLuong;
    }

    public override void In()
    {
        base.In();
        Console.WriteLine($"Đơn vị: {DonVi}, Hệ số lương: {HeSoLuong}, Lương: {TinhLuong()}");
    }

    public double TinhLuong()
    {
        return HeSoLuong * LUONG_CO_BAN;
    }
}

class Program
{
    static void Main()
    {
        List<CoQuan> ds = new List<CoQuan>();

        Console.Write("Nhập số cá nhân: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cá nhân thứ {i + 1}");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Giới tính (Nam/Nữ): ");
            bool gioiTinh = Console.ReadLine().ToLower() == "nam";
            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Đơn vị: ");
            string donVi = Console.ReadLine();
            Console.Write("Hệ số lương: ");
            double hsl = double.Parse(Console.ReadLine());

            ds.Add(new CoQuan(hoTen, gioiTinh, tuoi, donVi, hsl));
        }

        string luaChon = "";
        while (luaChon != "3")
        {
            Console.WriteLine("\n1. Hiển thị thông tin người thuộc phòng tài chính");
            Console.WriteLine("2. Tìm kiếm theo họ tên");
            Console.WriteLine("3. Thoát");
            Console.Write("Lựa chọn: ");
            luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    foreach (var nv in ds)
                    {
                        if (nv.DonVi.ToLower() == "phòng tài chính")
                            nv.In();
                    }
                    break;
                case "2":
                    Console.Write("Nhập họ tên cần tìm: ");
                    string ten = Console.ReadLine();
                    foreach (var nv in ds)
                    {
                        if (nv.HoTen.ToLower().Contains(ten.ToLower()))
                            nv.In();
                    }
                    break;
            }
        }
    }
}
