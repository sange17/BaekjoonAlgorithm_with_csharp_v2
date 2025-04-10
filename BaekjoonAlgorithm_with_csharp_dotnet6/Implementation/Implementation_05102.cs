using System.Threading.Channels;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05102
    {
        public void solve()
        {
            while (true)
            {
                string line = Console.ReadLine()!;
                int A = Int32.Parse(line.Split(" ")[0]);
                int B = Int32.Parse(line.Split(" ")[1]);
                int diff = A - B;

                if (A == 0 && B == 0) break;

                if(diff > 3)
                {
                    Console.WriteLine(diff % 2 == 0 ? diff / 2 + " 0" : diff / 2 - 1 + " 1");
                }
                else if(diff == 3)
                    Console.WriteLine("0 1");
                else if (diff == 2) 
                    Console.WriteLine("1 0");
                else
                    Console.WriteLine("0 0");
            }
        }
    }
}
