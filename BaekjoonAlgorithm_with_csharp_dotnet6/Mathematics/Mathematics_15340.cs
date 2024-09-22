namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_15340
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int[] array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

                if (array[0] == 0 && array[1] == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                int[] prices = new int[3];
                prices[0] = array[0] * 30 + array[1] * 40;
                prices[1] = array[0] * 35 + array[1] * 30;
                prices[2] = array[0] * 40 + array[1] * 20;

                Array.Sort(prices);

                sw.WriteLine(prices[0]);
            }
        }
    }
}
