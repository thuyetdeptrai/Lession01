bool LaSoNguyenTo(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0) return false;
    return true;
}

void TimSoNguyenToTrongMang(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (LaSoNguyenTo(arr[i]))
            Console.WriteLine($"arr[{i}] = {arr[i]} là số nguyên tố");
    }
}
