using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_30501
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            string line = string.Empty;

            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();

                if(line.Contains('S'))
                {
                    Console.WriteLine(line);
                    break;
                }
            }
        }
    }
}
