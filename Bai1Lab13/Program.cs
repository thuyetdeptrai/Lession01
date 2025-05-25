using System;
using System.Collections.Generic;

class CanBo
{
    public string HoTen, GioiTinh, DiaChi;
    public int NamSinh;

    public virtual void Nhap()
    {
        Console.Write("Họ tên: "); HoTen = Console.ReadLine();
        Console.Write("Năm sinh: "); NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Giới tính: "); GioiTinh = Console.ReadLine();
        Console.Write("Địa chỉ: "); DiaChi = Console.ReadLine();
    }

    public virtual void Xuat()
    {
        Console.WriteLine($"{HoTen} | {NamSinh} | {GioiTinh} | {DiaChi}");
    }

    public virtual string Loai() => "Cán bộ";
}

class CongNhan : CanBo
{
    public string Bac;
    public override void Nhap() { base.Nhap(); Console.Write("Bậc: "); Bac = Console.ReadLine(); }
    public override void Xuat() { base.Xuat(); Console.WriteLine($"Bậc: {Bac}"); }
    public override string Loai() => "Công nhân";
}

class KySu : CanBo
{
    public string Nganh;
    public override void Nhap() { base.Nhap(); Console.Write("Ngành: "); Nganh = Console.ReadLine(); }
    public override void Xuat() { base.Xuat(); Console.WriteLine($"Ngành: {Nganh}"); }
    public override string Loai() => "Kỹ sư";
}

class NhanVien : CanBo
{
    public string CongViec;
    public override void Nhap() { base.Nhap(); Console.Write("Công việc: "); CongViec = Console.ReadLine(); }
    public override void Xuat() { base.Xuat(); Console.WriteLine($"Công việc: {CongViec}"); }
    public override string Loai() => "Nhân viên";
}

class QLCB
{
    List<CanBo> ds = new List<CanBo>();

    public void Nhap()
    {
        Console.Write("Chọn (1.Công nhân 2.Kỹ sư 3.Nhân viên): ");
        string chon = Console.ReadLine();
        CanBo cb = chon == "1" ? new CongNhan() : chon == "2" ? new KySu() : new NhanVien();
        cb.Nhap();
        ds.Add(cb);
    }

    public void TimKiem()
    {
        Console.Write("Nhập tên cần tìm: ");
        string ten = Console.ReadLine();
        foreach (var cb in ds)
            if (cb.HoTen.Contains(ten, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"--- {cb.Loai()} ---");
                cb.Xuat();
            }
    }

    public void HienThi()
    {
        foreach (var cb in ds)
        {
            Console.WriteLine($"--- {cb.Loai()} ---");
            cb.Xuat();
        }
    }
}

class Program
{
    static void Main()
    {
        QLCB ql = new QLCB();
        while (true)
        {
            Console.WriteLine("\n1. Thêm cán bộ\n2. Tìm kiếm\n3. Hiển thị\n4. Thoát");
            Console.Write("Chọn: ");
            string chon = Console.ReadLine();
            if (chon == "1") ql.Nhap();
            else if (chon == "2") ql.TimKiem();
            else if (chon == "3") ql.HienThi();
            else if (chon == "4") break;
        }
    }
}
