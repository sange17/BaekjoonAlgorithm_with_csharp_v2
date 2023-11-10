using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_28248
    {
        public void solve()
        {
            int P = Int32.Parse(Console.ReadLine());
            int C = Int32.Parse(Console.ReadLine());

            if(P > C)
            {
                Console.WriteLine(P * 50 - C * 10 + 500);
            }
            else
            {
                Console.WriteLine(P * 50 - C * 10);
            }
        }
    }
}
