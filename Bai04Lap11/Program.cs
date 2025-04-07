// Thiết lập để hỗ trợ tiếng Việt
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Khai báo biến
int soNguyen;

// Nhập số nguyên từ bàn phím
Console.Write("Nhập một số nguyên: ");
soNguyen = int.Parse(Console.ReadLine());

// Kiểm tra chẵn/lẻ
if (soNguyen % 2 == 0)
{
    Console.WriteLine($"{soNguyen} là số chẵn.");
}
else
{
    Console.WriteLine($"{soNguyen} là số lẻ.");
}