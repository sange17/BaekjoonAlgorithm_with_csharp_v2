using System;
using System.IO;

namespace BaekjoonAlgorithm_with_csharp_v2.Implementation
{
    class Implementation_02448
    {
        static int bottom = 0;
        static int middle = 0;
        static String space = string.Empty;
        static void makeBigStar(int k, String[] map)
        {
            bottom = 3 * (int)Math.Pow(2, k);
            middle = bottom / 2;

            for(int i = middle; i < bottom; ++i)
            {
                map[i] = map[i - middle] + " " + map[i - middle];
            }

            space = String.Empty;
            while(space.Length < middle)
            {
                space += " ";
            }

            for(int i = 0; i < middle; ++i)
            {
                map[i] = space + map[i] + space;
            }
        }

        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());

            String[] map = new String[n];
            map[0] = "  *  ";
            map[1] = " * * ";
            map[2] = "*****";

            for(int k = 1; 3 * (int)Math.Pow(2, k) <= n; ++k)
            {
                makeBigStar(k, map);
            }

            for(int i = 0; i < n; ++i)
            {
                sw.WriteLine(map[i]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
