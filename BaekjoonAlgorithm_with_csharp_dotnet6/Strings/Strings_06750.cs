namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_06750
    {
        public void solve()
        {
            string line = Console.ReadLine();

            bool flag = true;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != 'I'
                && line[i] != 'O'
                && line[i] != 'S'
                && line[i] != 'H'
                && line[i] != 'Z'
                && line[i] != 'X'
                && line[i] != 'N')
                {
                    flag = false; 
                    break;
                }
            }

            if(flag)
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
        }
    }
}
