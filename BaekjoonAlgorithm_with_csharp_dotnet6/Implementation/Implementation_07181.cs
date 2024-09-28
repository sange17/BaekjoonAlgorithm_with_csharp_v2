namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_07181
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine()!;
            int n = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                string arv = sr.ReadLine()!;
                int a = 0;
                int b = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (line.Contains(arv[j])) a++;
                    if (arv[j] == line[j]) b++;
                }
                sw.WriteLine(a + " " + b);
            }

            sr.Close();
            sw.Close();
        }
    }
}
