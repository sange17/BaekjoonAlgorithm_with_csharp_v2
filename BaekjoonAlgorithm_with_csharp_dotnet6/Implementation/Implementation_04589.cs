using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04589
    {
        public void solve()
        {
            int t = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Gnomes:");

            string[] array1;
            int[] array2 = new int[3];
            while(t-- != 0)
            {
                array1 = Console.ReadLine().Split(' ');
                for (int i = 0; i < 3; i++) array2[i] = Int32.Parse(array1[i]);

                if ((array2[1] - array2[0]) * (array2[2] - array2[1]) >  0)
                {
                    Console.WriteLine("Ordered");
                }
                else
                {
                    Console.WriteLine("Unordered");
                }
            }
        }
    }
}
