Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập số thứ nhất: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Nhập số thứ hai: ");
double b = double.Parse(Console.ReadLine());

double tong = a + b;
double tich = a * b;

Console.WriteLine($"Tổng: {tong}");
Console.WriteLine($"Tích: {tich}");