//1. lập trình đồng bộ
class Program
{
    //    static string DownloadData()
    //    {
    //        Thread.Sleep(5000);//giả lập thời gian tải dữ liệu
    //        return "Data từ server";
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Bắt đầu tải dữ liệu");
    //        string result = DownloadData();//chặn tại đây, không cho làm việc khác 
    //        //khi tải xong thì mới thực hiện các lệnh dưới

    //        for(int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine("Đang làm việc khác");
    //            Thread.Sleep(1000);
    //        }
    //        Console.WriteLine($"Tải xong {result}");
    //    }
    //2. Lập trình bất đồng bộ
    static async Task<string> DownloadData()
{
    await Task.Delay(5000); //giả lập thời gian tải dữ liệu
    return "Data từ server";
}
    static async Task Main(string[] args)
{
    Console.WriteLine("Bắt đầu tải dữ liệu");
    var task = DownloadData(); //không chặn tại đây, cho phép làm việc khác
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Đang làm việc khác.....{i}");
        await Task.Delay(1000);
    }
    var result = await task; //chờ tải xong
    Console.WriteLine($"Tải xong {result}");
}
}


