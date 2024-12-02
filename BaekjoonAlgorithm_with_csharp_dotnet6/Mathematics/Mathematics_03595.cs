namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_03595
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            long min = long.MaxValue;
            int[] num = new int[3];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i * j > n) break;

                    for (int k = 1; k <= j; k++)
                    {
                        if(i * j * k > n) break;
                        if (i * j * k == n)
                        {
                            long sum = i * j + j * k + k * i;
                            if (sum < min)
                            {
                                min = sum;
                                num[0] = i;
                                num[1] = j;
                                num[2] = k;
                            }
                        }
                    }
                }
            }

            Console.Write(num[0] + " " + num[1] + " " + num[2]);
        }
    }
}
