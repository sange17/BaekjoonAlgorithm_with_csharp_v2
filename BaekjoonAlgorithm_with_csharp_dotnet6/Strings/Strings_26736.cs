namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_26736
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int cntA = 0;
            int cntB = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'A') cntA++;
                else cntB++;
            }

            Console.Write(cntA + " : " + cntB);
        }
    }
}
