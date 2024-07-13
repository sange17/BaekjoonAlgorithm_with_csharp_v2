namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_17174
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int n = Int32.Parse(line.Split(" ")[0]);
            int m = Int32.Parse(line.Split(" ")[1]);

            int count = n;
            while (n >= m)
            {
                count += (n / m);
                n /= m;
            }

            Console.Write(count);
        }
    }
}
