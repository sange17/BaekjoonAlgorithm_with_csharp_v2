namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06436
    {
        static int MAX_FILE_SIZE = 62 * 30000;

        public void solve()
        {
            int cnt = 1;
            while (true)
            {
                int s = Int32.Parse(Console.ReadLine()!);
                if (s == 0) break;

                s = s % 2 != 0 ? s / 2 + 1 : s / 2;

                s += s % 2 != 0 ? s / 2 + 1 : s / 2;

                int floppiesCnt = (s + (MAX_FILE_SIZE - 1)) / MAX_FILE_SIZE;

                Console.WriteLine("File #" + cnt);
                Console.WriteLine("John needs " + floppiesCnt + " floppies.\n");
                cnt++;
            }
        }
    }
}
