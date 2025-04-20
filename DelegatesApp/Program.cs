static void Info(string s)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Info: {s}");
    Console.ResetColor();
}
static void Warning(string s)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Warning: {s}");
    Console.ResetColor();
}
static void Sum(int a, int b, Action<string> callback)
{
    int c = a + b;
    callback($"Sum: {c}");
}
Sum(3, 4, Info);
Sum(5, 6, Warning);