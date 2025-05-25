using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02Lab13
{
    class Tailieu
    {
        protected string? maTL;
        protected string? tenNXB;
        protected int? soBan;
        //phương thức khởi tạo 
    }
    public Tailieu ()
    {
    
        
     }

       //phương thức khởi tạo
    public Tailieu(String maTL, String tenNXB, int soBan)
        {
            this.maTL = maTL; 
            this.tenNXB = tenNXB;
            this.soBan = soBan;
        }
}
