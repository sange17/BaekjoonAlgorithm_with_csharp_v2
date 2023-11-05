using System;

namespace BaekjoonAlgorithm_with_csharp_v2.Implementation
{
    class Implementation_28453
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            string[] array = Console.ReadLine().Split(' ');
            int level = 0;
            for(int i = 0; i < N; i++)
            {
                level = Int32.Parse(array[i]);
                if (level == 300) Console.Write("1");
                else if (level < 300 && level >= 275) Console.Write("2");
                else if (level < 275 && level >= 250) Console.Write("3");
                else if (level < 250) Console.Write("4");

                if (i != N - 1) Console.Write(" ");
            }
        }
    }
}
