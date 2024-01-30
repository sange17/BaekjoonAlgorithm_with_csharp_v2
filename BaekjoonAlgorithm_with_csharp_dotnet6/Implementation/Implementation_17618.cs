using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_17618
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            int count = 0;

            for(int i = 1; i <= N; i++)
            {
                string line = i.ToString();
                int sum = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    sum += Int32.Parse(line[j].ToString());
                }

                if (i % sum == 0) count++;
            }
            Console.Write(count);
        }
    }
}
