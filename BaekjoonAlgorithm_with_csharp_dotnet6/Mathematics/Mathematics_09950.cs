namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_09950
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int[] array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

                if (array.Sum() == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                if (array[0] == 0)
                    array[0] = array[2] / array[1];
                else if (array[1] == 0)
                    array[1] = array[2] / array[0];
                else if (array[2] == 0)
                    array[2] = array[0] * array[1];

                sw.WriteLine(array[0] + " " + array[1] + " " + array[2]);
            }
        }
    }
}
