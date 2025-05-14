namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_27736
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            if(array.Where(x => x == 0).Count() >= array.Where(x => x != 0).Count())
                Console.Write("INVALID");
            else if(array.Sum() > 0)
                Console.Write("APPROVED");
            else if(array.Sum() <= 0)
                Console.Write("REJECTED");
        }
    }
}
