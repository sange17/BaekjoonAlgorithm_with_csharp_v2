namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_31282
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int count = 0;
            int sum = 0;
            while (true)
            {
                if (inputs[0] <= sum)
                {
                    Console.Write(count);
                    break;
                }

                inputs[0] += inputs[1];
                sum += inputs[2];
                count++;
            }
        }
    }
}
