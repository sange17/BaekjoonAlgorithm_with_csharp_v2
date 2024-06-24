using System.Runtime.CompilerServices;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_17598
    {
        public void solve()
        {
            int lion = 0;
            int tiger = 0;
            
            for (int i = 0; i < 9; i++)
            {
                if (Console.ReadLine() == "Lion")
                    lion++;
                else
                    tiger++;
            }

            if (lion > tiger)
                Console.Write("Lion");
            else
                Console.Write("Tiger");
        }
    }
}
