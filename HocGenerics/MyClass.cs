using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocGenerics
{
    class MyClass<T> // ràng buộc where T: class

    {
        private T data;
        public MyClass(T data)
        {
            this.data = data;
        }
        public T GetData()
        {
            return data;
        }
        public void DisplayData()
        {
            Console.WriteLine($"Giá trị: {data}");
        }
    }
}
