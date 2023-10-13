using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_29163
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            string[] line = Console.ReadLine().Split(' ');

            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if(Int32.Parse(line[i]) % 2 == 0)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }

            if(count1 > count2)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Sad");
            }
        }
    }
}
