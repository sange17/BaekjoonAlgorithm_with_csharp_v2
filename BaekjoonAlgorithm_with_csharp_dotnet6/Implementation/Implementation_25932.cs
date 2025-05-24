namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_25932
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                Console.WriteLine(string.Join(" ", array));

                if (array.Contains(18) && array.Contains(17))
                {
                    Console.WriteLine("both\n");
                }
                else if (!array.Contains(18) && !array.Contains(17))
                {
                    Console.WriteLine("none\n");
                }
                else if (array.Contains(17))
                {
                    Console.WriteLine("zack\n");
                }
                else if (array.Contains(18))
                {
                    Console.WriteLine("mack\n");
                }
            }
        }
    }
}
