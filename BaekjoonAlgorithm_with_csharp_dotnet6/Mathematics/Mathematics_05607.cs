using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05607
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            int aSum = 0;
            int bSum = 0;
            for(int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                int a = Int32.Parse(s.Split(" ")[0]);
                int b = Int32.Parse(s.Split(" ")[1]);

                if(a > b)
                {
                    aSum += (a + b);
                }
                else if(a < b)
                {
                    bSum += (a + b);
                }
                else
                {
                    aSum += a;
                    bSum += b;
                }
            }
            Console.Write(aSum + " " + bSum);
        }
    }
}
