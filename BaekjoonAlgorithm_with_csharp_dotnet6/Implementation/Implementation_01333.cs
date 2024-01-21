using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01333
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int n = Int32.Parse(line.Split(" ")[0]);
            int l = Int32.Parse(line.Split(" ")[1]);
            int d = Int32.Parse(line.Split(" ")[2]);

            List<bool> sec = new List<bool>();

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < l; j++)
                {
                    sec.Add(true);
                }

                if(i != n - 1)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        sec.Add(false);
                    }
                }
            }

            int result = 0;
            while(result < sec.Count)
            {
                if (sec[result] == false)
                {
                    break;
                }

                result += d;
            }

            Console.Write(result);
        }
    }
}
