namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_08721
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            string[] array = Console.ReadLine()!.Split(" ");

            int start = 1;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (Int32.Parse(array[i]) == start)
                    start++;
                else
                    count++;
            }

            Console.Write(count);
        }
    }
}
