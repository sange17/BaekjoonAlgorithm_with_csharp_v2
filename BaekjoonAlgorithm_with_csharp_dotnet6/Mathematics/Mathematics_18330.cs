namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_18330
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());
            int extra = 60 + k;

            if(n <= extra)
            {
                Console.Write(n * 1500);
            }else
            {
                Console.Write(extra * 1500 + (n - extra) * 3000);
            }
        }
    }
}
