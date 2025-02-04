namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_31281
    {
        public void solve()
        {
            long[] array = Console.ReadLine()!.Split(" ").Select(long.Parse).ToArray();
            Array.Sort(array);
            Console.Write(array[1]);
        }
    }
}
