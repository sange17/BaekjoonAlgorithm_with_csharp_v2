namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_30585
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int h = Int32.Parse(line.Split(" ")[0]);
            int w = Int32.Parse(line.Split(" ")[1]);
            int result = 0;

            int cnt1 = 0;
            int cnt0 = 0;
            for (int i = 0; i < h; i++)
            {
                line = Console.ReadLine();
                for (int j = 0; j < w; j++)
                {
                    if (line[j] == '1')
                        cnt1++;
                    else
                        cnt0++;
                }
            }

            Console.Write(Math.Min(cnt1, cnt0));
        }
    }
}
