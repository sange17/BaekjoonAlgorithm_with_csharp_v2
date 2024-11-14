namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02966
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;
            char[] adrian = { 'A', 'B', 'C' };
            char[] bruno = { 'B', 'A', 'B', 'C' };
            char[] goran = { 'C', 'C', 'A', 'A', 'B', 'B' };
            int adrianCnt = 0;
            int brunoCnt = 0;
            int goranCnt = 0;

            for (int i = 0; i < N; i++)
            {
                if (line[i] == adrian[i % adrian.Length]) adrianCnt++;
                if (line[i] == bruno[i % bruno.Length]) brunoCnt++;
                if (line[i] == goran[i % goran.Length]) goranCnt++;
            }

            int max = Math.Max(Math.Max(adrianCnt, brunoCnt), goranCnt);
            Console.WriteLine(max);
            if (adrianCnt == max) Console.WriteLine("Adrian");
            if (brunoCnt == max) Console.WriteLine("Bruno");
            if (goranCnt == max) Console.WriteLine("Goran");
        }
    }
}
