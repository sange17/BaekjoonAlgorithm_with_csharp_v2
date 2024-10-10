namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02774
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                List<char> list = new List<char>();
                string x = sr.ReadLine()!;
                int count = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    if (list.Contains(x[j]))
                    {
                        continue;
                    }
                    else
                    {
                        list.Add(x[j]);
                        count++;
                    }
                }

                sw.WriteLine(count);
            }

            sr.Close();
            sw.Close();
        }
    }
}
