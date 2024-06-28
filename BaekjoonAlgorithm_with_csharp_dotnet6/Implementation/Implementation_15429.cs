namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_15429
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());

            string[] array;
            for (int i = 0; i < n; i++)
            {
                array = sr.ReadLine().Split(" ");

                int m = Int32.Parse(array[0]) - 1;
                for (int j = 1; j <= m - 1; j++)
                {
                    if (Int32.Parse(array[j]) + 1 == Int32.Parse(array[j + 1]))
                        continue;
                    else
                    {
                        sw.WriteLine(j + 1);
                        break;
                    }
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
