namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_33162
    {
        public void solve()
        {
            int X = Int32.Parse(Console.ReadLine()!);
            int M = 0;

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0) M += 3;
                else if (i % 2 == 0) M -= 2;
            }

            Console.Write(M);
        }
    }
}
