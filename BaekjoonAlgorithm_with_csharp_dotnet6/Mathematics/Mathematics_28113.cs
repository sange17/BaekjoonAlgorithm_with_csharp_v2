using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_28113
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(" ")[0]);
            int A = Int32.Parse(line.Split(" ")[1]);
            int B = Int32.Parse(line.Split(" ")[2]);

            if(N + A < N + B)
            {
                Console.Write("Bus");
            }
            else if(N + A > N + B)
            {
                Console.Write("Subway");
            }
            else
            {
                Console.Write("Anything");
            }
        }
    }
}
