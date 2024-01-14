using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_02991
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int A = Int32.Parse(line.Split(' ')[0]);
            int B = Int32.Parse(line.Split(' ')[1]);
            int C = Int32.Parse(line.Split(' ')[2]);
            int D = Int32.Parse(line.Split(' ')[3]);

            line = Console.ReadLine();
            for(int i = 0; i < 3; i++)
            {
                int N = Int32.Parse(line.Split(' ')[i]);
                int dog1 = N % (A + B);
                int dog2 = N % (C + D);
                int count = 0;

                if(dog1 <= A && dog2 <= C)
                {
                    count = 2;
                }
                else if(dog1 <= A || dog2 <= C)
                {
                    count = 1;
                }

                if(dog1 == 0)
                {
                    count -= 1;
                }
                if(dog2 == 0)
                {
                    count -= 1;
                }
                Console.WriteLine(count);
            }
        }
    }
}
