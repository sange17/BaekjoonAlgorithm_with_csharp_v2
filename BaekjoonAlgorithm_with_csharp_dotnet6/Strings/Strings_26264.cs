namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_26264
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;

            int bigdata = 0;
            int security = 0;
            for(int i = 0; i < line.Length; i++)
            {
                if (line[i] == 's')
                {
                    security++;
                }
                else if (line[i] == 'b')
                {
                    bigdata++;
                }
            }

            if (bigdata == security)
                Console.Write("bigdata? security!");
            else if (bigdata < security)
                Console.Write("security!");
            else if (bigdata > security)
                Console.Write("bigdata?");
        }
    }
}
