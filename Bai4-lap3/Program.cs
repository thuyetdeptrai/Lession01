using System;
using System.Collections.Generic;

class Nguoi
{
    public string SoCMND { get; set; }
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public int NamSinh { get; set; }
    public string NgheNghiep { get; set; }

    public Nguoi(string soCMND, string hoTen, int tuoi, int namSinh, string ngheNghiep)
    {
        SoCMND = soCMND;
        HoTen = hoTen;
        Tuoi = tuoi;
        NamSinh = namSinh;
        NgheNghiep = ngheNghiep;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"CMND: {SoCMND}, Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề nghiệp: {NgheNghiep}");
    }
}

class KhuPho
{
    public int SoNha { get; set; }
    public int SoThanhVien { get; set; }
    public List<Nguoi> ThanhVien { get; set; }

    public KhuPho(int soNha, int soThanhVien)
    {
        SoNha = soNha;
        SoThanhVien = soThanhVien;
        ThanhVien = new List<Nguoi>();
    }

    public void NhapThongTinThanhVien()
    {
        for (int i = 0; i < SoThanhVien; i++)
        {
            Console.WriteLine($"Nhập thông tin thành viên {i + 1}:");
            Console.Write("Số CMND: ");
            string soCMND = Console.ReadLine();
            Console.Write("Họ và tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nghề nghiệp: ");
            string ngheNghiep = Console.ReadLine();

            Nguoi nguoi = new Nguoi(soCMND, hoTen, tuoi, namSinh, ngheNghiep);
            ThanhVien.Add(nguoi);
        }
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Số nhà: {SoNha}, Số thành viên: {SoThanhVien}");
        foreach (var nguoi in ThanhVien)
        {
            nguoi.HienThiThongTin();
        }
    }

    public Nguoi TimKiemTheoHoTen(string hoTen)
    {
        foreach (var nguoi in ThanhVien)
        {
            if (nguoi.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase))
            {
                return nguoi;
            }
        }
        return null;
    }

    public Nguoi TimKiemTheoSoNha(int soNha)
    {
        if (this.SoNha == soNha)
        {
            return ThanhVien[0]; // Giả sử trả về thành viên đầu tiên của hộ gia đình
        }
        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<KhuPho> khuPho = new List<KhuPho>();
        Console.Write("Nhập số hộ dân: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin hộ dân {i + 1}:");
            Console.Write("Số nhà: ");
            int soNha = int.Parse(Console.ReadLine());
            Console.Write("Số thành viên: ");
            int soThanhVien = int.Parse(Console.ReadLine());

            KhuPho khu = new KhuPho(soNha, soThanhVien);
            khu.NhapThongTinThanhVien();
            khuPho.Add(khu);
        }

        Console.WriteLine("\nThông tin các hộ dân:");
        foreach (var khu in khuPho)
        {
            khu.HienThiThongTin();
        }

        // Tìm kiếm theo họ tên
        Console.Write("\nNhập họ tên cần tìm: ");
        string hoTenCanTim = Console.ReadLine();
        foreach (var khu in khuPho)
        {
            var nguoi = khu.TimKiemTheoHoTen(hoTenCanTim);
            if (nguoi != null)
            {
                Console.WriteLine($"Thông tin tìm thấy: {nguoi.HoTen}, {nguoi.SoCMND}");
            }
        }

        // Tìm kiếm theo số nhà
        Console.Write("\nNhập số nhà cần tìm: ");
        int soNhaCanTim = int.Parse(Console.ReadLine());
        foreach (var khu in khuPho)
        {
            var nguoi = khu.TimKiemTheoSoNha(soNhaCanTim);
            if (nguoi != null)
            {
                Console.WriteLine($"Thông tin hộ dân: {nguoi.HoTen}, {nguoi.SoCMND}");
            }
        }
    }
}
