using System;
using System.Collections.Generic;

class Nguoi
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string QueQuan { get; set; }
    public string SoCMND { get; set; }

    public Nguoi(string hoTen, int namSinh, string queQuan, string soCMND)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        QueQuan = queQuan;
        SoCMND = soCMND;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, CMND: {SoCMND}");
    }
}

class CBGV
{
    public double LuongCung { get; set; }
    public double Thuong { get; set; }
    public double Phat { get; set; }
    public double LuongThucLinh { get; set; }
    public Nguoi CanBo { get; set; }

    public CBGV(double luongCung, double thuong, double phat, Nguoi canBo)
    {
        LuongCung = luongCung;
        Thuong = thuong;
        Phat = phat;
        CanBo = canBo;
        LuongThucLinh = LuongCung + Thuong - Phat;
    }

    public void HienThiThongTin()
    {
        CanBo.HienThiThongTin();
        Console.WriteLine($"Lương cứng: {LuongCung}, Thưởng: {Thuong}, Phạt: {Phat}, Lương thực lĩnh: {LuongThucLinh}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<CBGV> danhSachCBGV = new List<CBGV>();
        Console.Write("Nhập số cán bộ giáo viên: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin cán bộ giáo viên {i + 1}:");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());
            Console.Write("Quê quán: ");
            string queQuan = Console.ReadLine();
            Console.Write("Số CMND: ");
            string soCMND = Console.ReadLine();

            Nguoi nguoi = new Nguoi(hoTen, namSinh, queQuan, soCMND);

            Console.Write("Lương cứng: ");
            double luongCung = double.Parse(Console.ReadLine());
            Console.Write("Thưởng: ");
            double thuong = double.Parse(Console.ReadLine());
            Console.Write("Phạt: ");
            double phat = double.Parse(Console.ReadLine());

            CBGV cbgv = new CBGV(luongCung, thuong, phat, nguoi);
            danhSachCBGV.Add(cbgv);
        }

        // Tìm kiếm theo quê quán
        Console.Write("\nNhập quê quán cần tìm: ");
        string queQuanCanTim = Console.ReadLine();
        foreach (var cbgv in danhSachCBGV)
        {
            if (cbgv.CanBo.QueQuan.Equals(queQuanCanTim, StringComparison.OrdinalIgnoreCase))
            {
                cbgv.HienThiThongTin();
            }
        }

        // Hiển thị cán bộ có lương thực lĩnh trên 5 triệu
        Console.WriteLine("\nCán bộ có lương thực lĩnh trên 5 triệu:");
        foreach (var cbgv in danhSachCBGV)
        {
            if (cbgv.LuongThucLinh > 5000000)
            {
                cbgv.HienThiThongTin();
            }
        }
    }
}
