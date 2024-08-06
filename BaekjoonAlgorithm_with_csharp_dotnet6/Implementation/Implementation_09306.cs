using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09306
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int tc = Int32.Parse(sr.ReadLine()!);

            for (int i = 1; i <= tc; i++)
            {
                string first = sr.ReadLine()!;
                string last = sr.ReadLine()!;

                if(i != tc)
                    sw.WriteLine("Case " + i + ": " + last + ", " + first);
                else
                    sw.Write("Case " + i + ": " + last + ", " + first);
            }

            sr.Close();
            sw.Close();
        }
    }
}
