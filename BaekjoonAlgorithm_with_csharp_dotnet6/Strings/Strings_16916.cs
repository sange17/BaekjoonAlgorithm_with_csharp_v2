namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_16916
    {
        static int KMP(string parent, string pattern)
        {
            int[] table = MakeTable(pattern);
            int n1 = parent.Length;
            int n2 = pattern.Length;
            int idx = 0;

            for(int i = 0; i < n1; i++)
            {
                while(idx > 0 && parent[i] != pattern[idx])
                {
                    idx = table[idx - 1];
                }

                if (parent[i] == pattern[idx])
                {
                    if(idx == n2 - 1)
                    {
                        idx = table[idx];
                        return 1;
                    }
                    else
                    {
                        idx += 1;
                    }
                }
            }

            return 0;
        }

        static int[] MakeTable(string pattern)
        {
            int n = pattern.Length;
            int[] table = new int[n];

            int idx = 0;
            for(int i = 1; i < n; i++)
            {
                while(idx > 0 && pattern[i] != pattern[idx])
                {
                    idx = table[idx - 1];
                }

                if (pattern[i] == pattern[idx])
                {
                    idx += 1;
                    table[i] = idx;
                }

            }
            return table;
        }

        public void solve()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(KMP(str1, str2));
        }
    }
}
