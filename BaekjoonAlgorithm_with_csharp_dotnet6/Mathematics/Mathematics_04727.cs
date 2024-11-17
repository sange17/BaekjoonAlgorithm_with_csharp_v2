namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04727
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string line = sr.ReadLine()!;

                if (line == "0 0 0 0")
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                //int[] array = line.Split(" ").Select(int.Parse).ToArray();
                //double min = Math.Round((array[1] - 0.5) * 9 + ((array[2] - 0.5) + (array[3] - 0.5)) * 4, MidpointRounding.AwayFromZero);
                //double max = Math.Round((array[1] + 0.4) * 9 + ((array[2] + 0.4) + (array[3] + 0.4)) * 4, MidpointRounding.AwayFromZero);

                //if (min <= array[0] && max >= array[0])
                //{
                //    sw.WriteLine("yes");
                //}
                //else
                //{
                //    sw.WriteLine("no");
                //}

                int[] array = line.Split(" ").Select(int.Parse).ToArray();

                if (array[0] == array[1] * 9 + (array[2] + array[3]) * 4)
                {
                    sw.WriteLine("yes");
                }
                else
                {
                    sw.WriteLine("no");
                }
            }
        }
    }
}
