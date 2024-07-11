namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_26535
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            int count = 1;
            while (true)
            {
                if (n <= count * count)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            
            for (int i = 0; i < count + 2; i++)
            {
                Console.Write("x");
            }

            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                Console.Write("x");
                for (int j = 0; j < count; j++)
                {
                    Console.Write(".");
                }
                Console.Write("x");
                Console.WriteLine();
            }


            for (int i = 0; i < count + 2; i++)
            {
                Console.Write("x");
            }
        }
    }
}
