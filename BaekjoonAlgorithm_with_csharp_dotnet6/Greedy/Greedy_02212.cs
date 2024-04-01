namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_02212
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());
            int K = Int32.Parse(sr.ReadLine());

            if(K >= N)
            {
                sw.WriteLine("0");
                sr.Close();
                sw.Close();
                return;
            }

            int[] censor = new int[N];
            string line = sr.ReadLine();
            for(int i = 0; i < N; i++)
            {
                int temp = Int32.Parse(line.Split(" ")[i]);
                censor[i] = temp;
            }
            Array.Sort(censor);

            int[] dif = new int[N - 1];
            for(int i = 0; i < N - 1; i++)
            {
                dif[i] = censor[i + 1] - censor[i];
            }
            Array.Sort(dif);

            int ans = 0;
            for(int i = 0; i < N - K; i++)
            {
                ans += dif[i];
            }

            sw.WriteLine(ans);
            sr.Close();
            sw.Close();
        }
    }
}
