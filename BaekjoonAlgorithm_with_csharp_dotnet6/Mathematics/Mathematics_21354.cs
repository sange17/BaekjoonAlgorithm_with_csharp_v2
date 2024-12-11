namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_21354
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            if (array[0] * 7 == array[1] * 13)
                Console.Write("lika");
            else if (array[0] * 7 > array[1] * 13)
                Console.Write("Axel");
            else if (array[0] * 7 < array[1] * 13)
                Console.Write("Petra");
        }
    }
}
