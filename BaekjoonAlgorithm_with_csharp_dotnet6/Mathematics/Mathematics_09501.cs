using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_09501
    {
        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < T; i++)
            {
                string line = Console.ReadLine();
                int N = Int32.Parse(line.Split(" ")[0]);
                double P = Double.Parse(line.Split(" ")[1]);
                int count = 0;

                for (int j = 0; j < N; j++)
                {
                    line = Console.ReadLine();
                    double v = Double.Parse(line.Split(" ")[0]);
                    double f = Double.Parse(line.Split(" ")[1]);
                    double c = Double.Parse(line.Split(" ")[2]);

                    if ((P / v) * c <= f)
                        count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
