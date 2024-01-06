using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_30045
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            string line = string.Empty;
            int count = 0;
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();

                if (line.Contains("01"))
                {
                    count++;
                }
                else if(line.Contains("OI"))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
