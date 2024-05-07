using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_30658
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int input = Int32.Parse(sr.ReadLine());
                if(input == 0)
                {
                    sr.Close();
                    sw.Close();
                    return;
                }

                int[] array = new int[input];
                for(int i = 0; i < array.Length; i++)
                    array[i] = Int32.Parse(sr.ReadLine());


                for(int i = array.Length - 1; i >= 0; i--)
                    sw.WriteLine(array[i]);

                sw.WriteLine(0);
            }
        }
    }
}
