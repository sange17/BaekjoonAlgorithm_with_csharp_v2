namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_02495
    {
        public void solve()
        {
            string line;
            int lineLength = 0;

            for(int i = 0; i < 3; i++)
            {
                line = Console.ReadLine();
                lineLength = line.Length;

                int max = 0;
                int cnt = 0;
                for(int j = 0; j < lineLength - 1; j++)
                {
                    if (line[j] == line[j + 1])
                    {
                        cnt++;
                    }
                    else
                    {
                        cnt = 0;
                    }

                    if (cnt > max) max = cnt;
                }
                Console.WriteLine(max + 1);
            }
        }
    }
}
