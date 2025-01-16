namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_30868
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < T; i++)
            {
                int n = Int32.Parse(sr.ReadLine()!);
                int n1 = n % 5;
                int n5 = n / 5;

                for (int j = 0; j < n5; j++)
                    sw.Write("++++ ");

                for (int j = 0; j < n1; j++)
                    sw.Write("|");

                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
