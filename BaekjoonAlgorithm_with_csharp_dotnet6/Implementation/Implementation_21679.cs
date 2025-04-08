namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_21679
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int[] arrayN = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int k = Int32.Parse(Console.ReadLine()!);
            int[] arrayK = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < k; i++)
                arrayN[arrayK[i] - 1]--;

            for(int i = 0; i < n; i++)
            {
                if (arrayN[i] < 0)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
        }
    }
}
