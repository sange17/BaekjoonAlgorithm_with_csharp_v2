using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_23080
    {
        public void solve()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            for (int i = 0; i < line.Length; i += n)
            {
                sb.Append(line[i]);
            }

            Console.Write(sb.ToString());
        }
    }
}
