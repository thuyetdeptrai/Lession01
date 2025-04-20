
static void LoiChao(string name)
{
    Console.WriteLine($"Chao Xìn {name}");
}
//2. Khởi tạo delegates
//TinhToan tt = new TinhToan(TinhTong);
//Func<int, int, int> tt = delegate(int x, int y)//phương thức nặc danh(Anonymous method) là khối code không tên
////và được khai báo bàng từ khóa delegate
//{
//    return x + y;
//};


//Biểu thức lambda: là cãh viết ngắn gọn hơn của phương thức nặc danh
//Func<int, int, int> tt = (int x, int y)=>{return x + y;};
Func<int, int, int> tt = (x, y) =>  x + y;
//HienThi ht = new HienThi(LoiChao);
Action<string> ht = (string name) => Console.WriteLine($"Chao Xìn {name}");

Action<string> ht = LoiChao;

//3. Thực thi delegates
Console.WriteLine("Tổng là: "+tt(10, 20));
ht("Thuyet");

//1. Khai báo delegates
//public delegate int TinhToan(int a, int b);
//public delegate void HienThi(string s);