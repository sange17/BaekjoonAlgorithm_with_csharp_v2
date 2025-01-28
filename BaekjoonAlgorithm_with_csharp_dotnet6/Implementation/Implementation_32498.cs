namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_32498
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int d = Int32.Parse(Console.ReadLine()!);

                if (d % 2 != 0) count++;
            }

            Console.Write(count);
        }
    }
}
