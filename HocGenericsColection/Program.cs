//1. List<T>: tuongw tujw nhuw ArryList nhungw csc phaafn tuử phải được xác định kieeru số liệu trc
//List<string> list = new List<string>();
//list.Add("Thuyet");
//list.Add("Ha");
//list.Add("B");


//C# 3.0 có thể viết lại như sau
using HocGenericsColection;

List<string> list = new List<string>()
{
    "Thuyet",
    "Ha",
    "B"
};

//List<KhachHang> listKH = new List<KhachHang>();
//-Các phương thức giống như ArrayList
//KhachHang kh1 = new KhachHang() { MaKH = 1, HoTen = "Nguyen Van Thuyet" };
//KhachHang kh2 = new KhachHang() { MaKH = 2, HoTen = "Nguyen Van Thu" };
//KhachHang kh3 = new KhachHang() { MaKH = 3, HoTen = "Nguyen Van Thuy" };
//C# 3.0 có thể viết lại như sau
List<KhachHang> listKH = new List<KhachHang>()
{
      new KhachHang() { MaKH = 1, HoTen = "Nguyen Van Thuyet" },
      new KhachHang() { MaKH = 2, HoTen = "Nguyen Van Thu" },
      new KhachHang() { MaKH = 3, HoTen = "Nguyen Van Thuy" }
};

    //C# 3.0 có thể viết lại như sau
//2. Dictionary<K,V>: tương tự như Hashtable nhưng phải xác định kiểu dữ liệu cho key và value
//Dictionary<int, string> dic = new Dictionary<int, string>();
//dic.Add(1, "Thuyet");
//dic.Add(2, "Ha");
//C# 3.0 có thể viết lại như sau
Dictionary<int, string> dic = new Dictionary<int, string>()
{
    { 1, "Thuyet" },
    { 2, "Ha" }
};