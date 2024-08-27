namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_14545
    {
        public void solve()
        {
            // 입출력
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            long P = Int32.Parse(sr.ReadLine()!);

            for (long k = 0; k < P; k++)
            {
                long I = long.Parse(sr.ReadLine()!);

                sw.WriteLine((I * (I + 1) * (2 * I + 1) / 6));
            }

            sr.Close();
            sw.Close();
        }
    }
}
