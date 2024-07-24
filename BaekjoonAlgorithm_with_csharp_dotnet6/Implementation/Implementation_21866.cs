using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_21866
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int sum = 0;
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > 100) && i < 2)
                {
                    flag = true;
                    break;
                }
                else if ((array[i] > 200) && (i > 1 && i < 4))
                {
                    flag = true;
                    break;
                }
                else if ((array[i] > 300) && (i > 3 && i < 6))
                {
                    flag = true;
                    break;
                }
                else if ((array[i] > 400) && (i > 5 && i < 8))
                {
                    flag = true;
                    break;
                }
                else if ((array[i] > 500) && i == 8)
                {
                    flag = true;
                    break;
                }

                sum += array[i];
            }

            if (flag)
            {
                Console.Write("hacker");
            }
            else
            {
                if (sum >= 100)
                {
                    Console.Write("draw");
                }
                else
                {
                    Console.Write("none");
                }
            }
        }
    }
}
