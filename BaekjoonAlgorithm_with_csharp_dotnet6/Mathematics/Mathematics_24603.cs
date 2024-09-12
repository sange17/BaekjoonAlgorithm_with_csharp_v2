namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24603
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            double[] array = sr.ReadLine()!.Split().Select(double.Parse).ToArray();

            for (int i = 0; i < array[0]; i++)
            {
                double n = double.Parse(sr.ReadLine()!);

                sw.WriteLine(Convert.ToInt32(n / array[1] * array[2]));
            }

            sr.Close();
            sw.Close();
        }
    }
}
