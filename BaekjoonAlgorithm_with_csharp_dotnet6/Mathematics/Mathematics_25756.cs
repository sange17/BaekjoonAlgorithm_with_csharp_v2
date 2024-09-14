namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25756
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);
            double[] array = sr.ReadLine()!.Split().Select(double.Parse).ToArray();

            double defense = 0;
            for (int i = 0; i < N; i++)
            {
                defense = 1 - (1 - defense) * (1 - array[i] / 100.0);

                sw.WriteLine(Math.Round((defense * 100), 7));
            }

            sr.Close();
            sw.Close();
        }
    }
}
