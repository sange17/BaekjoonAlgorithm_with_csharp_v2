namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_31280
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            Array.Sort(array);
            Console.Write(1 + array[1] + array[2] + array[3]);
        }
    }
}
