Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập một số: ");
double so = double.Parse(Console.ReadLine());

if (so > 0)
    Console.WriteLine("Số dương.");
else if (so < 0)
    Console.WriteLine("Số âm.");
else
    Console.WriteLine("Số không.");