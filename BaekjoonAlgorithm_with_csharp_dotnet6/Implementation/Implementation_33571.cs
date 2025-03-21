namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_33571
    {
        public void solve()
        {
            char[] array = { 'A', 'a', 'b', 'D', 'd', 'e', 'g', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', '@' };
            string line = Console.ReadLine()!;
            int count = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (array.Contains(line[i])) count++;
                else if (line[i] == 'B') count += 2;
            }

            Console.Write(count);
        }
    }
}
