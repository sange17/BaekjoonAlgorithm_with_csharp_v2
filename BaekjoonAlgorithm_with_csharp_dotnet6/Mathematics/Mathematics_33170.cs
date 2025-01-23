namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_33170
    {
        public void solve()
        {
            int a = Int32.Parse(Console.ReadLine()!);
            int b = Int32.Parse(Console.ReadLine()!);
            int c = Int32.Parse(Console.ReadLine()!);

            if (a + b + c <= 21)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
