namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_08714
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string[] array = Console.ReadLine()!.Split(" ");

            int one = 0;
            int zero = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == "1") one++;
                else zero++;
            }

            Console.Write(Math.Min(one, zero));
        }
    }
}
