namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    internal class Mathematics_18238
    {
        public void solve()
        {
            string input = Console.ReadLine()!;
            char current = 'A';
            int totalTime = 0;

            foreach (char target in input)
            {
                int distance = Math.Abs(current - target);
                totalTime += Math.Min(distance, 26 - distance);
                current = target;
            }

            Console.Write(totalTime);
        }
    }
}
