namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_02702
    {
        public int GCD(int a, int b)
        {
            if (a % b == 0) return b;

            return GCD(b, a % b);
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < N; i++)
            {
                int[] array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

                int k = GCD(array[0], array[1]);
                sw.WriteLine((array[0] * array[1] / k) + " " + k);
            }

            sr.Close();
            sw.Close();
        }
    }
}
