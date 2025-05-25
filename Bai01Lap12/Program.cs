int TinhTongSoChan(int[] arr)
{
    int tong = 0;
    foreach (int x in arr)
    {
        if (x % 2 == 0)
            tong += x;
    }
    return tong;
}