using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_v2.Strings
{
    class Strings_29766
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int lineLength = line.Length;

            int count = 0;
            for(int i = 0; i < lineLength - 3; i++)
            {
                if(line[i] == 'D' && line[i + 1] == 'K' && line[i + 2] == 'S' && line[i + 3] == 'H')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
