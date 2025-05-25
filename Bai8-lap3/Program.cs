using System;
using System.Collections.Generic;

class SinhVien
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string Lop { get; set; }
    public string MaSoSV { get; set; }

    public void NhapThongTin()
    {
        Console.Write("Họ tên: ");
        HoTen = Console.ReadLine();
        Console.Write("Năm sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Lớp: ");
        Lop = Console.ReadLine();
        Console.Write("Mã số sinh viên: ");
        MaSoSV = Console.ReadLine();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Lớp: {Lop}, Mã số SV: {MaSoSV}");
    }
}

class TheMuon
{
    public string SoPhieuMuon { get; set; }
    public DateTime NgayMuon { get; set; }
    public DateTime HanTra { get; set; }
    public string SoHieuSach { get; set; }
    public SinhVien SV { get; set; }

    public void NhapThongTin()
    {
        SV = new SinhVien();
        Console.WriteLine("Nhập thông tin sinh viên:");
        SV.NhapThongTin();

        Console.Write("Số phiếu mượn: ");
        SoPhieuMuon = Console.ReadLine();
        Console.Write("Ngày mượn (yyyy-MM-dd): ");
        NgayMuon = DateTime.Parse(Console.ReadLine());
        Console.Write("Hạn trả (yyyy-MM-dd): ");
        HanTra = DateTime.Parse(Console.ReadLine());
        Console.Write("Số hiệu sách: ");
        SoHieuSach = Console.ReadLine();
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("\n===== Thông tin thẻ mượn =====");
        SV.HienThiThongTin();
        Console.WriteLine($"Số phiếu mượn: {SoPhieuMuon}");
        Console.WriteLine($"Ngày mượn: {NgayMuon.ToShortDateString()}");
        Console.WriteLine($"Hạn trả: {HanTra.ToShortDateString()}");
        Console.WriteLine($"Số hiệu sách: {SoHieuSach}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<TheMuon> danhSach = new List<TheMuon>();
        int luaChon;

        do
        {
            Console.WriteLine("\n=========== MENU ==========");
            Console.WriteLine("1. Nhập danh sách thẻ mượn");
            Console.WriteLine("2. Tìm sinh viên theo mã số SV");
            Console.WriteLine("3. Hiển thị sinh viên đến hạn trả sách");
            Console.WriteLine("4. Thoát chương trình");
            Console.Write("Chọn chức năng (1–4): ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    Console.Write("Nhập số lượng thẻ mượn: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"\n--- Nhập thẻ mượn thứ {i + 1} ---");
                        TheMuon tm = new TheMuon();
                        tm.NhapThongTin();
                        danhSach.Add(tm);
                    }
                    break;

                case 2:
                    Console.Write("\nNhập mã số sinh viên cần tìm: ");
                    string maSV = Console.ReadLine();
                    bool timThay = false;
                    foreach (var tm in danhSach)
                    {
                        if (tm.SV.MaSoSV.Equals(maSV, StringComparison.OrdinalIgnoreCase))
                        {
                            tm.HienThiThongTin();
                            timThay = true;
                        }
                    }
                    if (!timThay)
                    {
                        Console.WriteLine("Không tìm thấy sinh viên với mã số này!");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nCác sinh viên đến hạn trả sách:");
                    DateTime ngayHienTai = DateTime.Now;
                    bool coHanTra = false;
                    foreach (var tm in danhSach)
                    {
                        if (tm.HanTra.Date <= ngayHienTai.Date)
                        {
                            tm.HienThiThongTin();
                            coHanTra = true;
                        }
                    }
                    if (!coHanTra)
                    {
                        Console.WriteLine("Không có sinh viên nào đến hạn trả sách.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Thoát chương trình. Tạm biệt!");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại!");
                    break;
            }

        } while (luaChon != 4);
    }
}

