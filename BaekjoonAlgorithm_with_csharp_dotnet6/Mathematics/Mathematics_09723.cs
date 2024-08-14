namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_09723
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);

            for (int i = 1; i <= N; i++)
            {
                int[] array = sr.ReadLine()!.Split().Select(int.Parse).ToArray();
                Array.Sort(array);

                if (array[2] * array[2] == array[0] * array[0] + array[1] * array[1])
                    sw.WriteLine("Case #" + i + ": YES");
                else
                    sw.WriteLine("Case #" + i + ": NO");
            }

            sr.Close();
            sw.Close();
        }
    }
}
