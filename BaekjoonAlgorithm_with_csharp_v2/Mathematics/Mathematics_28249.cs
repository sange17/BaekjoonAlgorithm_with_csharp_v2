using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_28249
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            int sum = 0;
            string line = string.Empty;
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();

                if (line.Equals("Poblano"))
                {
                    sum += 1500;
                }
                else if(line.Equals("Mirasol"))
                {
                    sum += 6000;
                }
                else if(line.Equals("Serrano"))
                {
                    sum += 15500;
                }
                else if(line.Equals("Cayenne"))
                {
                    sum += 40000;
                }
                else if(line.Equals("Thai"))
                {
                    sum += 75000;
                }
                else if (line.Equals("Habanero"))
                {
                    sum += 125000;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
