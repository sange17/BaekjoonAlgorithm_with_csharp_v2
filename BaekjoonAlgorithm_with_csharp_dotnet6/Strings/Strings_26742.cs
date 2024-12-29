namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_26742
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int bCount = 0;
            int cCount = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'B') bCount++;
                else if(line[i] == 'C') cCount++;
            }
            Console.Write(bCount / 2 + cCount / 2);
        }
    }
}
