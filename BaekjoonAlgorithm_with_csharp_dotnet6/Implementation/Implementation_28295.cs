namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_28295
    {
        public void solve()
        {
            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                result += Int32.Parse(Console.ReadLine());

                if (result > 3)
                {
                    result %= 4;
                }
            }

            if (result == 0)
            {
                Console.Write("N");
            }
            else if (result == 1)
            {
                Console.Write("E");
            }
            else if (result == 2)
            {
                Console.Write("S");
            }
            else if (result == 3)
            {
                Console.Write("W");
            }
        }
    }
}
