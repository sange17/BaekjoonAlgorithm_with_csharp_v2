namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_08712
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);

            int num = 1;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    int temp = num;
                    for (int j = N - 1; j >= 0; j--)
                    {
                        sw.Write((temp + j) + " ");
                        num++;
                    }
                }
                else
                {
                    for (int j = 0; j < N; j++)
                    {
                        sw.Write(num + " ");
                        num++;
                    }
                }

                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
