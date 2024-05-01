namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04349
    {
        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                int n = Int32.Parse((Console.ReadLine()));
                List<List<int>> list = new List<List<int>>();
                for (int i = 1; i < n + 1; i++)
                {
                    for (int j = 1; j < n + 1; j++)
                    {
                        if (i * j > n) break;
                        int k = (n / i) / j;
                        if (i * j * k == n) list.Add(new List<int> { i, j, k });
                    }
                }
                int min = int.MaxValue;
                foreach (List<int> l in list)
                {
                    if (min > 2 * (l[0] * l[1] + l[1] * l[2] + l[2] * l[0]))
                        min = 2 * (l[0] * l[1] + l[1] * l[2] + l[2] * l[0]);
                }

                Console.WriteLine(min);
            }
        }
    }
}
