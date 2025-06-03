namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    internal class Mathematics_15818
    {
        public void solve()
        {
            string inputs = Console.ReadLine()!;
            int n = Int32.Parse(inputs.Split(" ")[0]);
            int m = Int32.Parse(inputs.Split(" ")[1]);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            long result = 1;

            for (int i = 0; i < n; i++)
            {
                array[i] %= m;
                result = (result * array[i]) % m;
            }

            Console.Write(result);
        }
    }
}
