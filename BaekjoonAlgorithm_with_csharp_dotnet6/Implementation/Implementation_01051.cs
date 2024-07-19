namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01051
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int n = Int32.Parse(line.Split(" ")[0]);
            int m = Int32.Parse(line.Split(" ")[1]);

            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine()!;
                for (int j = 0; j < m; j++)
                {
                    array[i,j] = line[j] - 48;
                }
            }

            int max = 1;


            if (n == 1 || m == 1)
            {
                max = 1;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    int length = 1;
                    for (int j = 0; j < m; j++)
                    {
                        while (true)
                        {
                            // 정사각형이 영역을 벗어나는 경우
                            if (i + length > n - 1 || j + length > m - 1) break;

                            if (array[i, j] == array[i, j + length] 
                             && array[i, j] == array[i + length, j] 
                             && array[i, j] == array[i + length, j + length])
                            {
                                if(max < length + 1)
                                    max = length + 1;
                            }

                            length++;
                        }
                    }
                }
            }

            Console.WriteLine(max * max);
        }
    }
}
