namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_30979
    {
        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine()!);
            int N = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            if (array.Sum() >= T) Console.Write("Padaeng_i Happy");
            else Console.Write("Padaeng_i Cry");
        }
    }
}
