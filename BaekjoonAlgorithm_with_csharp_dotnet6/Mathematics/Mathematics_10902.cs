namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_10902
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int max = 0;
            int min = int.MaxValue;
            int f = 0;

            int[] tArray = new int[n + 1];
            int[] sArray = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                string line = Console.ReadLine()!;
                int t = Int32.Parse(line.Split(" ")[0]);
                int s = Int32.Parse(line.Split(" ")[1]);

                tArray[i] = t;
                sArray[i] = s;
            }

            max = sArray.Max();

            for (int i = 1; i <= n; i++)
            {
                if (sArray[i] == max)
                {
                    if (tArray[i] < min)
                    {
                        min = tArray[i];
                        f = i;
                    }
                }
            }

            if (max == 0)
                Console.Write(0);
            else
                Console.Write(min + (f - 1) * 20);
        }
    }
}
