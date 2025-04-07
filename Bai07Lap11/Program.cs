Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập năm: ");
int nam = int.Parse(Console.ReadLine());

if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
    Console.WriteLine($"{nam} là năm nhuận.");
else
    Console.WriteLine($"{nam} không phải là năm nhuận.");