using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Implementation
{
    class Implementation_27918
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            string line = string.Empty;
            int a = 0;
            int b = 0;

            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();
                if(line.Equals("D"))
                {
                    a++;
                }
                else
                {
                    b++;
                }

                if(Math.Abs(a - b) == 2)
                {
                    Console.WriteLine(a + ":" + b);
                    break;
                }

                if(i == N - 1)
                {
                    Console.WriteLine(a + ":" + b);
                }
            }
        }
    }
}
