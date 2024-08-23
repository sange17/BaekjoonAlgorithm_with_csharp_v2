namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_15178
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine()!;
                int[] angles = line.Split().Select(int.Parse).ToArray();

                if (angles.Sum() == 180)
                {
                    sw.WriteLine(line + " Seems OK");
                }
                else
                {
                    sw.WriteLine(line + " Check");
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
