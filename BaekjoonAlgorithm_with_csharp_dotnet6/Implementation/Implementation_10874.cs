namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_10874
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < N; i++)
            {
                int[] array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                bool[] chkArr = new bool[array.Length];
                for (int j = 1; j <= 10; j++)
                {
                    if (array[j - 1] == ((j - 1) % 5 + 1)) 
                        chkArr[j - 1] = true;
                }

                if (!chkArr.Contains(false))
                    sw.WriteLine(i + 1);
            }

            sr.Close();
            sw.Close();
        }
    }
}
