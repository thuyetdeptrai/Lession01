// Khai báo biến
int chieuDai = 0;
int chieuRong = 0;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập chiều dài: ");
chieuDai = int.Parse(Console.ReadLine());

Console.Write("Nhập chiều rộng: ");
chieuRong = int.Parse(Console.ReadLine());

double ToTal = chieuDai * chieuRong;

Console.WriteLine($"Diện tích hình chữ nhật là: {ToTal}");
