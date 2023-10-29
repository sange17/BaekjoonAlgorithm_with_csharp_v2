using System;
using System.IO;

namespace BaekjoonAlgorithm_with_csharp_v2.Implementation
{
    class Implementation_29340
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line1 = sr.ReadLine();
            char[] array1 = line1.ToCharArray();

            string line2 = sr.ReadLine();
            char[] array2 = line2.ToCharArray();

            for (int i = 0; i < line1.Length; i++)
            {
                if (array1[i] - '0' > array2[i] - '0')
                {
                    sw.Write(array1[i]);
                }
                else if (array1[i] - '0' <= array2[i] - '0')
                {
                    sw.Write(array2[i]);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}