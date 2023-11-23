using System;

namespace BaekjoonAlgorithm_with_v2.implementation
{
    class Implementation_30676
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            if (N >= 620 && N <= 780)
            {
                Console.WriteLine("Red");
            }
            else if (N >= 590 && N < 620)
            {
                Console.WriteLine("Orange");
            }
            else if (N >= 570 && N < 590)
            {
                Console.Write("Yellow");
            }
            else if (N >= 495 && N < 570)
            {
                Console.WriteLine("Green");
            }
            else if (N >= 450 && N < 495)
            {
                Console.WriteLine("Blue");
            }
            else if (N >= 425 && N < 450)
            {
                Console.WriteLine("Indigo");
            }
            else if (N >= 380 && N < 425)
            {
                Console.WriteLine("Violet");
            }
        }
    }
}