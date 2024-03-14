using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01806
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int n = Int32.Parse(line.Split(" ")[0]);
            int s = Int32.Parse(line.Split(" ")[1]);

            int[] nums = new int[n + 1];
            string[] strings = Console.ReadLine().Split(" ");
            for(int i = 0; i < n; i++)
            {
                nums[i] = Int32.Parse(strings[i]);
            }

            int min = Int32.MaxValue;
            int start = 0;
            int end = 0;
            int total = 0;
            while (start <= n && end <= n)
            {
                if(total >= s && min > end - start)
                    min = end - start;

                if (total < s)
                    total += nums[end++];
                else total -= nums[start++];
            }

            if (min == Int32.MaxValue) Console.WriteLine("0");
            else Console.Write(min);
        }
    }
}
