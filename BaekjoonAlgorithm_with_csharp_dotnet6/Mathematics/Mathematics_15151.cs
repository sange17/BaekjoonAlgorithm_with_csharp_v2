namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_15151
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int count = 0;

            while (inputs[1] >= 0)
            {
                inputs[1] -= inputs[0] * (1 << count++);
            }

            Console.Write(count - 1);
        }
    }
}
