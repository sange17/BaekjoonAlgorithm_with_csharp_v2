namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_14761
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int x = inputs[0];
            int y = inputs[1];
            int n = inputs[2];

            for (int i = 1; i <= n; i++)
            {
                if (i % x != 0 && i % y != 0)
                {
                    Console.Write(i);
                }
                else
                {
                    if (i % x == 0) Console.Write("Fizz");
                    if (i % y == 0) Console.Write("Buzz");
                }

                Console.WriteLine();
            }
        }
    }
}
