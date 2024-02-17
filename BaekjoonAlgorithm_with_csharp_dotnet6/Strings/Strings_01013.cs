using System.Text.RegularExpressions;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_01013
    {
        static bool Matching(string pattern)
        {
            if (pattern.StartsWith("01"))
            {
                if (pattern.Length == 2) return true;
                if (Matching(pattern.Substring(2))) return true;
            }
            else if (Regex.IsMatch(pattern, @"^100+1+[01]*$"))
            {
                int s = pattern.IndexOf('1', 1);
                int e = s;
                while (pattern[e] == '1')
                {
                    if (pattern.Length == e + 1) return true;
                    e++;
                }
                for (int i = s; i < e; i++)
                {
                    if (Matching(pattern.Substring(i + 1))) return true;
                }
            }
            return false;
        }

        public void solve()
        {
            int t = int.Parse(Console.ReadLine());

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (t-- > 0)
            {
                string line = Console.ReadLine();
                sb.Append(Matching(line) ? "YES\n" : "NO\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
