void DemSoAmVaDuong(int[] arr, out int soAm, out int soDuong)
{
    soAm = 0;
    soDuong = 0;

    foreach (int x in arr)
    {
        if (x > 0) soDuong++;
        else if (x < 0) soAm++;
    }
}
