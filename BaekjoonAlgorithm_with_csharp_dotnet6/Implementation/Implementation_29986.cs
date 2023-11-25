using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_29986
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int kinds = Int32.Parse(line.Split(' ')[0]);
            int height = Int32.Parse(line.Split(' ')[1]);

            string[] array = Console.ReadLine().Split(' ');
            int count = 0;
            for (int i = 0; i < kinds; i++)
            {
                if (Int32.Parse(array[i]) <= height) count++;
            }

            Console.Write(count);
        }
    }
}
