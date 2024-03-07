using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_05586
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int length = line.Length;

            int joiCnt = 0;
            int ioiCnt = 0;

            if(length < 3)
            {
                Console.Write(joiCnt + "\n" + ioiCnt);
            }
            else
            {
                for(int i = 0; i < length - 2; i++)
                {
                    if(line.Substring(i, 3) == "JOI") joiCnt++;
                    else if (line.Substring(i, 3) == "IOI") ioiCnt++;
                }

                Console.Write(joiCnt + "\n" + ioiCnt);
            }
        }
    }
}
