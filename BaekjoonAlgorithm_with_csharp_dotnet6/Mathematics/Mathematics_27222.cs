namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27222
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine()!;

                if (array[i] == 1)
                {
                    int x = int.Parse(line.Split(" ")[0]);
                    int y = int.Parse(line.Split(" ")[1]);

                    if(y - x > 0) sum += (y - x);
                }
            }

            Console.Write(sum);
        }
    }
}
