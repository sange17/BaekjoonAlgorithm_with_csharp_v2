namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_28097
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int sum = array.Sum() + (array.Length - 1) * 8;
            Console.Write(sum / 24 + " " + sum % 24);
        }
    }
}
