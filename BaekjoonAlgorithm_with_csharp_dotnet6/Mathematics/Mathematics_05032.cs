namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05032
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int sum = 0;
            int bottles = array[0] + array[1];

            while (true)
            {
                if (bottles < array[2])
                {
                    Console.Write(sum);
                    break;
                }
                else
                {
                    sum += bottles / array[2];
                    bottles = bottles / array[2] + bottles % array[2];
                }
            }
        }
    }
}
