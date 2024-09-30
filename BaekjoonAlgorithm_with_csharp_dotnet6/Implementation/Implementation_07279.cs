namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_07279
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int n = Convert.ToInt32(line.Split(" ")[0]);
            int k = Convert.ToInt32(line.Split(" ")[1]);

            int sum = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine()!;
                int ai = Convert.ToInt32(line.Split(" ")[0]);
                int bi = Convert.ToInt32(line.Split(" ")[1]);

                sum += ai;
                sum -= bi;

                if (sum > k)
                {
                    sum -= k;
                    if (max < sum)
                    {
                        max = sum;
                    }
                }
            }

            Console.Write(max);
        }
    }
}
