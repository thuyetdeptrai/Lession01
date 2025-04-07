using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02Lab13
{
    class Sach : Tailieu // : kế thừa
    {
        private string? tenTG;
        private int soTrang;
        //phương thức khởi tạo mặc định
        public Sach()
        {

        }
        //phương thức khởi tạo cso tham số
        public Sach(String maTL, String tenNXB, int soBan,
            string tenTG, int soTrang) : base(maTL,tenNXB,soBan) 
        {
           this.tenTG = tenTG;
           this.soTrang = soTrang; 

        }
        //phương thức nhập thông tin sách
        public override void Nhap()
        {
            base.Nhap(); //gọi lại từ lớp cha
            Console.WriteLine("+Ten tác giả: ");
            tenTG = Console.ReadLine();
            Console.WriteLine("+ Số trang: ");
            soTrang = int.Parse(Console.ReadLine()?? "0");
        }
        //phương thức hiển thị thông tin sách
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+Tên tác giả: {tenTG}");
            Console.WriteLine($"+Số trang: {soTrang}");
        }
    }
}
