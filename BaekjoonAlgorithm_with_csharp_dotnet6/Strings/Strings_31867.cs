namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31867
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;
            int evenCnt = 0;
            int oddCnt = 0;
            for (int i = 0; i < N; i++)
            {
                if ((line[i] - '0') % 2 == 0) evenCnt++;
                else oddCnt++;
            }

            if(evenCnt == oddCnt)
                Console.Write(-1);
            else if(evenCnt > oddCnt)
                Console.Write(0);
            else
                Console.Write(1);
        }
    }
}
