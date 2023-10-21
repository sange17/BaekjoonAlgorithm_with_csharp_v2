using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_v2.Implementation
{
    class Implementation_30087
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            string line = string.Empty;
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();

                if (line.Equals("Algorithm")) Console.WriteLine("204");
                if (line.Equals("DataAnalysis")) Console.WriteLine("207");
                if (line.Equals("ArtificialIntelligence")) Console.WriteLine("302");
                if (line.Equals("CyberSecurity")) Console.WriteLine("B101");
                if (line.Equals("Network")) Console.WriteLine("303");
                if (line.Equals("Startup")) Console.WriteLine("501");
                if (line.Equals("TestStrategy")) Console.WriteLine("105");
            }
        }
    }
}
