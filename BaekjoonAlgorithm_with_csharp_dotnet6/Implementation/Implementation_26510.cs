namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_26510
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i]; j++)
                {
                    for (int k = 0; k < j; k++) Console.Write(" ");
                    Console.Write("*");
                    if (j != array[i] - 1)
                    {
                        for (int k = 0; k < (array[i] - j) * 2 - 3; k++) Console.Write(" ");
                        Console.Write("*");
                    }

                    if (i == array.Length - 1 && j == array[i] - 1) continue;
                    else Console.WriteLine();
                }
            }
        }
    }
}
