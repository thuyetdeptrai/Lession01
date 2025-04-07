Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập số nguyên dương n: ");
int n = int.Parse(Console.ReadLine());

long giaiThua = 1;
for (int i = 1; i <= n; i++)
{
    giaiThua *= i;
}

Console.WriteLine($"{n}! = {giaiThua}");