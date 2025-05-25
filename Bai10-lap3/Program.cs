using System;
using System.Text.RegularExpressions;

class VanBan
{
    public string NoiDung;
    public VanBan() => NoiDung = "";
    public VanBan(string s) => NoiDung = s;
    public int DemSoTu() => NoiDung.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    public int DemKyTuH() => Regex.Matches(NoiDung, "[hH]").Count;
    public string ChuanHoa() => Regex.Replace(NoiDung.Trim(), @"\s+", " ");
    public void Menu()
    {
        Console.WriteLine("1. Đếm từ\n2. Đếm ký tự H\n3. Chuẩn hóa\n0. Thoát");
        while (true)
        {
            Console.Write("Chọn: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 0) break;
            switch (chon)
            {
                case 1: Console.WriteLine($"Số từ: {DemSoTu()}"); break;
                case 2: Console.WriteLine($"Số ký tự H: {DemKyTuH()}"); break;
                case 3: Console.WriteLine($"Chuẩn hóa: \"{ChuanHoa()}\""); break;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập văn bản: ");
        string s = Console.ReadLine();
        VanBan vb = new(s);
        vb.Menu();
    }
}

