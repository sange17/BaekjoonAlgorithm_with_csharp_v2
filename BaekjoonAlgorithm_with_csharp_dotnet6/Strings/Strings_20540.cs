namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_20540
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            for (int i = 0; i < 4; i++)
            {
                if (line[i] == 'E') Console.Write("I");
                if (line[i] == 'I') Console.Write("E");
                if (line[i] == 'S') Console.Write("N");
                if (line[i] == 'N') Console.Write("S");
                if (line[i] == 'T') Console.Write("F");
                if (line[i] == 'F') Console.Write("T");
                if (line[i] == 'J') Console.Write("P");
                if (line[i] == 'P') Console.Write("J");
            }
        }
    }
}
