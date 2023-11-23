using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_26057
    {
        public void solve()
        {
            int L = Int32.Parse(Console.ReadLine());
            int T = Int32.Parse(Console.ReadLine());

            int idx = 1;
            while (true)
            {
                if(L < T * idx)
                {
                    Console.Write(T * idx - L);
                    break;
                }

                idx++;
            }
        }
    }
}
