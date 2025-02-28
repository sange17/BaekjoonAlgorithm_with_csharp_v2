namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_32025
    {
        public void solve()
        {
            decimal H = Int32.Parse(Console.ReadLine()!);
            decimal W = Int32.Parse(Console.ReadLine()!);

            Console.Write((int)(Math.Min(H, W) / 2 * 100));
        }
    }
}
