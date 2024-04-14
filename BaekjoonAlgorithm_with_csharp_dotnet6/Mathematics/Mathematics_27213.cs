namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27213
    {
        public void solve()
        {
            int M = Int32.Parse(Console.ReadLine());
            int N = Int32.Parse(Console.ReadLine());

            if(M < 3 || N < 3) Console.Write(M * N);
            else
            {
                int longSide = Math.Max(M, N);
                int shortSide = Math.Min(M, N);
                Console.Write(longSide * 2 + (shortSide - 2) * 2);
            }
        }
    }
}
