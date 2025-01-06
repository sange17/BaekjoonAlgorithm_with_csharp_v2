namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_05013
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine()!;
                if (!line.Contains("CD")) count++;
            }

            Console.Write(count);
        }
    }
}
