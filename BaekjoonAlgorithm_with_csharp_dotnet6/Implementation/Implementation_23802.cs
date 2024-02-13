namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_23802
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());

            
            for (int j = 0; j < N; j++)
            {
                for (int k = 0; k < N * 5; k++)
                {
                    sw.Write("@");
                }
                sw.WriteLine();
            }

            for (int j = 0; j < (5 - 1) * N; j++)
            {
                for (int k = 0; k < N; k++)
                {
                    sw.Write("@");
                }
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
