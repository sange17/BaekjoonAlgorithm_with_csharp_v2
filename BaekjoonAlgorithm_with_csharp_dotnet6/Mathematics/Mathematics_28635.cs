namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_28635
    {
        public void solve()
        {
            int m = Int32.Parse(Console.ReadLine()!);
            int a = Int32.Parse(Console.ReadLine()!);
            int b = Int32.Parse(Console.ReadLine()!);
            if(a > b) Console.Write(m - a + b);
            else if(a < b) Console.Write(b - a);
            else if(a == b) Console.Write(0);
        }
    }
}
