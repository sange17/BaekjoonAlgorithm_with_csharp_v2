namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_25270
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            if (n < 100)
            {
                Console.Write(99);
            }
            else
            {
                int down = n;
                int up = n;

                while (true)
                {
                    if (++up % 100 == 99)
                    {
                        Console.Write(up);
                        break;
                    }

                    if (--down % 100 == 99)
                    {
                        Console.Write(down);
                        break;
                    }
                }
            }
        }
    }
}
