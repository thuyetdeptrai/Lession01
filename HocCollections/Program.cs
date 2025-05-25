// 1.ArryList 
//- 1 mảng động
//-Cho phép chứa các phaanf tử khác kiểu dữ liệu
//-Có thể chứa phần tử null và trùng nhau
//- truy xuất phần tử thông qua chỉ số
using System.Collections;
using HocCollections;
Console.OutputEncoding = System.Text.Encoding.UTF8;

ArrayList list = new ArrayList();
//-thêm phaafn tưt vào AryList
list.Add("Thuyết");
list.Add("Hà");
list.Add('B');
list.Add(8);
SinhVien sv = new SinhVien();
sv.maSV = 1;
sv.HoTen = "Nguyễn Văn A";
list.Add(sv);
//-Try xuất phần tưt thông qua chỉ số
Console.WriteLine(list[0]);
//-Chèn phần tử vào Arylist
list.Insert(1, "Ha");
//-Xóa phần tử trong ArrayList
list.Remove("Ha");//-xóa theo giá trị
list.RemoveAt(0);//-xóa theo chỉ số
//-TÌm kiếm phần tử trong ArrayList
Console.WriteLine(list.IndexOf("Hà"));//-vị trí đầu tiên
Console.WriteLine(list.LastIndexOf("Thuyết"));//-vị trí cuối cùng
Console.WriteLine(list.Contains("Hà"));//-true
//-Duyệt phần tử trong ArrayList
foreach (object item in list)
{
    if (item is SinhVien sinhVien)
    {
        Console.WriteLine($"Mã SV: {sinhVien.maSV}, Họ tên: {sinhVien.HoTen}");
    }
    else
    {
        Console.WriteLine(item);
    }
}

//2. HasTable
//-là tập hợp các phần tử
//-mỗi phần tử là  cặp key-value
//-Key phải là duy nhất và khác null
//-Truy xuất phần tử thông qua key

//Hashtable ht = new Hashtable();
////-thêm phần tử vào hastable
//ht.Add("Tuấn", 10);
//ht.Add(20, 100);
//ht.Add("Anh", 1000);
//ht.Add("Hà", "Thuyết");
////-truy xuất phân tuwr tỏng hastable
//Console.WriteLine(ht["Anh"]);//1000
////-Xoasphaafn tử trong hastable
//ht.Remove("Anh");//-Xóa theo key
////Đuyệt các phần tử trong hastable
////+ Cách 1: Duyệt theo chiều dọc 
//ICollection keys  = ht.keys;
//foreach (object key in keys)
//{
//    Console.WriteLine($"{key}, {ht[key]}");
//}

////+ CÁch 2: duyệt theo chiều ngang
//foreach(DictionaryEntry entry in ht)
//{
//    Console.WriteLine($"{entry.Key}, {entry.Value}");
//}    