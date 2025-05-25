int TimSoLonThuHai(int[] arr)
{
    int max1 = int.MinValue, max2 = int.MinValue;
    foreach (int x in arr)
    {
        if (x > max1)
        {
            max2 = max1;
            max1 = x;
        }
        else if (x > max2 && x != max1)
        {
            max2 = x;
        }
    }
    return max2;
}

