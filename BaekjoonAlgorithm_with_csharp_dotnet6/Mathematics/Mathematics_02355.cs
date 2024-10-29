using System.Diagnostics;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_02355
    {
        public void solve()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            long[] array = sr.ReadLine()!.Split(" ").Select(long.Parse).ToArray();
            Array.Sort(array);

            sw.Write((array[0] + array[1]) * (array[1] - array[0] + 1) / 2);

            sr.Close();
            sw.Close();

            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
