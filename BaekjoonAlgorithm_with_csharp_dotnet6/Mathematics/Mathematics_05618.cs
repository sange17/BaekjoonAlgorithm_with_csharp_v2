namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05618
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);
            int[] array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            Array.Sort(array);

            if (n == 2)
            {
                for (int i = 1; i <= array[n - 1]; i++)
                {
                    if (array[0] % i == 0 && array[1] % i == 0)
                        sw.WriteLine(i);
                }
            }
            else if (n == 3)
            {
                for (int i = 1; i <= array[n - 1]; i++)
                {
                    if (array[0] % i == 0 && array[1] % i == 0 && array[2] % i == 0)
                        sw.WriteLine(i);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
