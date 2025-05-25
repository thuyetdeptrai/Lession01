// Thiết lập để hiển thị tiếng Việt
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Khai báo biến
double doC, doF;

// Nhập nhiệt độ độ C
Console.Write("Nhập nhiệt độ (°C): ");
doC = double.Parse(Console.ReadLine());

// Chuyển đổi sang độ F
doF = (doC * 9 / 5) + 32;

// Xuất kết quả
Console.WriteLine($"Nhiệt độ tương đương theo độ F là: {doF}°F");