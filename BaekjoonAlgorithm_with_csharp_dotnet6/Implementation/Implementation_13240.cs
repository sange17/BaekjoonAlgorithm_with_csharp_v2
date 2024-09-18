namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_13240
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            for (int i = 1; i <= array[0]; i++)
            {
                for (int j = 1; j <= array[1]; j++)
                {
                    // 홀수 행이고 홀수 열일 때
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        sw.Write("*");
                    }
                    // 홀수 행이고 짝수 열일 때
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        sw .Write(".");
                    }
                    // 짝수 행이고 홀수 열일 때
                    else if (i % 2 == 0 && j % 2 != 0)
                    {
                        sw.Write(".");
                    }
                    // 짝수 행이고 짝수 열일 때
                    else if (i % 2 == 0 && j % 2 == 0)
                    {
                        sw.Write("*");
                    }
                }
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
