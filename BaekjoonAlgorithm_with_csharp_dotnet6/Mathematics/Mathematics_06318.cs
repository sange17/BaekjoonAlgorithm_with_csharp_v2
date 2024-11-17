namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06318
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int idx = 1;
            while (true)
            {
                int n = Int32.Parse(sr.ReadLine()!);
                
                if (n == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                int[] array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                int avg = array.Sum() / n;

                int sum = 0;
                for (int i = 0; i < n; i++)
                    if (array[i] > avg) sum += array[i] - avg;

                sw.WriteLine("Set #" + idx);
                sw.WriteLine("The minimum number of moves is " + sum +".");
                idx++;
            }
        }
    }
}
