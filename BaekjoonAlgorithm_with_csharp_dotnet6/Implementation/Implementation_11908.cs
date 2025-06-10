namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    internal class Implementation_11908
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            Array.Sort(array);

            int sum = array.Sum() - array[array.Length - 1];

            Console.Write(sum);
        }
    }
}
