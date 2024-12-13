namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04299
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            if (array[0] < array[1])
                Console.Write(-1);
            else
            {
                int x = (array[0] + array[1]) / 2;
                int y = (array[0] - array[1]) / 2;
                if (x + y == array[0] && x - y == array[1])
                    Console.Write(x + " " + y);
                else
                    Console.Write(-1);
            }
        }
    }
}
