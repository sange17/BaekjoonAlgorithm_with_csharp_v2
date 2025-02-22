namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_30143
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int T = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < T; i++)
            {
                string line = sr.ReadLine()!;
                int N = Int32.Parse(line.Split(" ")[0]);
                int A = Int32.Parse(line.Split(" ")[1]);
                int D = Int32.Parse(line.Split(" ")[2]);

                int sum = 0;
                int temp = A;
                for (int j = 0; j < N; j++)
                {
                    sum += temp;
                    temp += D;
                }

                sw.WriteLine(sum);
            }

            sr.Close();
            sw.Close();
        }
    }
}
