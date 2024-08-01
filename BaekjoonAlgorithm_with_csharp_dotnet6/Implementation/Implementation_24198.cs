namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_24198
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            int man1 = 0;
            int man2 = 0;
            bool turn = false;

            while (n > 0)
            {
                if (turn)
                {
                    man1 += (n - (n / 2));
                    turn = false;
                }
                else
                {
                    man2 += (n - (n / 2));
                    turn = true;
                }

                n -= (n - (n / 2));
            }

            Console.Write(man1 + " " + man2);
        }
    }
}
