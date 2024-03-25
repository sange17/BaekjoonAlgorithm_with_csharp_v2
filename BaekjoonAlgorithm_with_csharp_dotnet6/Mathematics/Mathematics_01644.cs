namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01644
    {
        static int n = 0;
        static bool[] isPrime;
        static List<int> list;

        static void makePrime()
        {
            isPrime = new bool[n + 1];
            Array.Fill<bool>(isPrime, true);

            isPrime[0] = isPrime[1] = false;
            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (isPrime[i])
                    list.Add(i);
            }
            list.Add(0);
        }

        public void solve()
        {
            n = Int32.Parse(Console.ReadLine());
            list = new List<int>();
            makePrime();

            int start = 0;
            int end = 0;
            int sum = 0;
            int cnt = 0;
            while (start <= end && end < list.Count)
            {
                if (sum < n)
                {
                    sum += list[end++];
                }
                else
                {
                    if (sum == n)
                        cnt++;
                    sum -= list[start++];
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
