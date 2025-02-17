namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    internal class Mathematics_29683
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int n = Int32.Parse(line.Split(" ")[0]);
            int A = Int32.Parse(line.Split(" ")[1]);

            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count += (array[i] / A);
            }

            Console.Write(count);
        }
    }
}
