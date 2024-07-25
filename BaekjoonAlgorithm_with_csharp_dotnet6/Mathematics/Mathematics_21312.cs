using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_21312
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Array.Sort(array);

            int count = 0;
            bool[] odds = new bool[3];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    count++;
                    odds[i] = true;
                }
            }

            if (count == 3 || count == 0)
            {
                Console.Write(array[0] * array[1] * array[2]);
            }
            else if (count == 2)
            {
                if (odds[0] && odds[1])
                {
                    Console.Write(array[0] * array[1]);
                }
                else if (odds[0] && odds[2])
                {
                    Console.Write(array[0] * array[2]);
                }
                else if (odds[1] && odds[2])
                {
                    Console.Write(array[1] * array[2]);
                }
            }
            else if (count == 1)
            {
                if (odds[0])
                {
                    Console.Write(array[0]);
                }
                else if (odds[1])
                {
                    Console.Write(array[1]);
                }
                else if (odds[2])
                {
                    Console.Write(array[2]);
                }
            }
        }
    }
}
