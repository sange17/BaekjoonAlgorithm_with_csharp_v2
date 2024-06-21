namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09839
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());
            int[] array = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int num = Int32.Parse(sr.ReadLine());
                array[num] = i;
            }

            for (int i = 1; i <= n; i++)
            {
                sw.WriteLine(array[i]);
            }
            sr.Close();
            sw.Close();
        }
    }
}
