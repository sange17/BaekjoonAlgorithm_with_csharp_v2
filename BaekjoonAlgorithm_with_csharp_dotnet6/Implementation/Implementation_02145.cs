namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02145
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        public void Play(string num)
        {
            int sum = 0;
            while (true)
            {
                sum = num.ToCharArray().Sum(x => (x - 48));

                if (sum < 10)
                {
                    sw.WriteLine(sum);
                    break;
                }
                num = sum.ToString();
            }
        }

        public void solve()
        {
            while (true)
            {
                string N = sr.ReadLine()!;
                if (N == "0")
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                Play(N);
            }
        }
    }
}
