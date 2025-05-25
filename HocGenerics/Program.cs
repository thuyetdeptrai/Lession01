using HocGenerics;

static void printArry<T>(T[] a)//-dùng kiểu T sẽ không bị lỗi kiểu
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i] + " ");
    }
}

int[] a = { 1, 2, 3, 4, 5 };
double[] b = { 4.2, 5.9, 9.2 };
string[] c = { "a", "b", "c" };
printArry(a);
printArry(b);
printArry(c);

MyClass<int> list1 = new MyClass<int>(10);
list1.DisplayData();

MyClass<string> list2 = new MyClass<string>("Hisn");
list2.DisplayData();

MyClass<SanPham> list3 = new MyClass<SanPham>(new SanPham());