namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_20473
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int n = 0;
            int m = 0;
            while (N % 3 != 0)
            {
                N -= 2;
                n++;
            }

            m = N / 3;

            Console.Write(n + " " + m);
        }
    }
}
