//? toán từ hợp nhất null
//int? x = null;
//int y = x ?? 100; //nếu x là null thì y sẽ là giá trị 100
//Console.WriteLine(y);
Console.OutputEncoding =System.Text.Encoding.UTF8;
//khai báo biến
string?ten;  //? là cho phép nhập gt null
int tuoi;
//Nhập dữ liệu từ bàn phím
Console.Write("Mời bạn nhập tên: " );
ten = Console.ReadLine();
Console.Write("Nhập tuổi: ");
tuoi = int.Parse(Console.ReadLine()??"0");

//xuất ra màn hình 
//Console.WriteLine("Xin chào "+ten ", bạn "+tuoi+" tuổi");
Console.WriteLine($"Xin chào {ten}, bạn {tuoi}, tuổi"); // chuỗi nội suy