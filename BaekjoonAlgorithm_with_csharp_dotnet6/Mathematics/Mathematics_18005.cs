using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_18005
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            if(N % 2 == 1)
            {
                Console.Write(0);
                return;
            }
            else
            {
                if(((1 + N) % 2 == 1) && ((N / 2) % 2 == 1))
                {
                    Console.Write(1);
                    return;
                }
                else
                {
                    Console.Write(2);
                    return;
                }
            }
        }
    }
}
