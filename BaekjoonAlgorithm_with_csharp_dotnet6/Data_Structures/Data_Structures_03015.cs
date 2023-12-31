using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_03015
    {
        static int N = 0;
        static Stack<Pair> stack = new Stack<Pair>();
        static long cnt = 0;

        public class Pair
        {
            public int height = 0;
            public int cnt = 0;

            public Pair(int height, int  cnt)
            {
                this.height = height;
                this.cnt = cnt;
            }
        }
        
        public void solve()
        {
            N = Int32.Parse(Console.ReadLine());
            int n = 0;

            for(int i = 0; i < N; i++)
            {
                n = Int32.Parse(Console.ReadLine());
                Pair pair = new Pair(n, 1);

                while(stack.Count() > 0 && stack.Peek().height <= n)
                {
                    Pair pop = stack.Pop();
                    cnt += pop.cnt;
                    if (pop.height == n)
                        pair.cnt += pop.cnt;
                }

                if (stack.Count > 0)
                    cnt++;

                stack.Push(pair);
            }

            Console.Write(cnt);
        }
    }
}
