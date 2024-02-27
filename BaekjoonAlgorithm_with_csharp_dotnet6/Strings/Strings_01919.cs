namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_01919
    {
        public void solve()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int cnt = 0;
            int[] countStr1 = new int[26];
            int[] countStr2 = new int[26];

            for(int i = 0; i < str1.Length; i++)
            {
                countStr1[str1[i] - 'a']++;
            }

            for (int i = 0; i < str2.Length; i++)
            {
                countStr2[str2[i] - 'a']++;
            }

            for(int i = 0; i < 26; i++)
            {
                int compare = countStr1[i] - countStr2[i];
                if (compare != 0) cnt += Math.Abs(compare);
            }

            Console.WriteLine(cnt);
        }
    }
}
