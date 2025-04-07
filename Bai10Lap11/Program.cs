Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập số nguyên: ");
int n = int.Parse(Console.ReadLine());

bool laSoNguyenTo = true;

if (n <= 1)
    laSoNguyenTo = false;
else
{
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            laSoNguyenTo = false;
            break;
        }
    }
}

if (laSoNguyenTo)
    Console.WriteLine($"{n} là số nguyên tố.");
else
    Console.WriteLine($"{n} không phải là số nguyên tố.");
