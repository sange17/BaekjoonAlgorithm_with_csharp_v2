namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_15784
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            string line = sr.ReadLine()!;
            int n = Int32.Parse(line.Split(" ")[0]);
            int a = Int32.Parse(line.Split(" ")[1]) - 1;
            int b = Int32.Parse(line.Split(" ")[2]) - 1;

            int[,] array = new int[n, n];

            int max = 0;
            for (int i = 0; i < n; i++)
            {
                line = sr.ReadLine()!;

                for (int j = 0; j < n; j++)
                {
                    if (i == a || j == b)
                    {
                        array[i, j] = Int32.Parse(line.Split(" ")[j]);
                        if (max < array[i, j]) max = array[i, j];
                    }
                }
            }

            if (array[a, b] < max)
                Console.Write("ANGRY");
            else
                Console.Write("HAPPY");

            sr.Close();
        }
    }
}
