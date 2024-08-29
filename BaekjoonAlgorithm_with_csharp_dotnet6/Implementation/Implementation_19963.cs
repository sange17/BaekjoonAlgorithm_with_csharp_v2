namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_19963
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] array = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            int n = array[0];
            int m = array[1];
            int k = array[2];

            int[] bag1 = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            int[] bag2 = sr.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            bool[] bag3 = new bool[n + 1];

            for (int i = 0; i < m; i++) bag3[bag1[i]] = true;
            for (int i = 0; i < k; i++) bag3[bag2[i]] = true;

            sw.WriteLine(bag3.Where(x => x == false).Count() - 1);

            for (int i = 1; i <= n; i++)
            {
                if (!bag3[i])
                {
                    sw.Write(i + " ");
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
