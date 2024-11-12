namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04864
    {
        public void solve()
        {
            int[] array = new int[10001];
            int sum = 0;
            int count = 1;
            int i = 1;
            while (true)
            {
                if (count > 10000) break;

                for (int j = 0; j < i; j++)
                {
                    if (count > 10000) break;
                    sum += i;
                    array[count] = sum;
                    count++;
                }

                i++;
            }

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int N = Int32.Parse(sr.ReadLine()!);
                if (N == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                sw.WriteLine(N + " " + array[N]);
            }
        }
    }
}
