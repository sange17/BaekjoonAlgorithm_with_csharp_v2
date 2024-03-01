namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_01254
    {
        static bool isPalind(string str)
        {
            int start = 0;
            int last = str.Length - 1;
            while(start <= last)
            {
                if (str[start] != str[last]) return false;
                start++;
                last--;
            }
            return true;
        }

        public void solve()
        {
            string line = Console.ReadLine();
            int ans = line.Length;
            for(int i = 0; i < line.Length; i++)
            {
                if (isPalind(line.Substring(i))) break;
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
