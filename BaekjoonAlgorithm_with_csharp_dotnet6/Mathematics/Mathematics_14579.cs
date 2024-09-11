namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_14579
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int sum = 0;
            int result = 1;
            for (int i = inputs[0]; i <= inputs[1]; i++)
            {
                sum = i * (i + 1) / 2;
                result *= sum;
                result %= 14579;
            }

            Console.Write(result);
        }
    }
}
