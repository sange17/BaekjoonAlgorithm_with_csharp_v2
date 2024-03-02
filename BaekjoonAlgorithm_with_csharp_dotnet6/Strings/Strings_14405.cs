namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_14405
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int idx = 0;
            while(true)
            {
                if (idx + 1 <= line.Length - 1 && line[idx] == 'p' && line[idx + 1] == 'i') idx += 2;
                else if (idx + 1 <= line.Length - 1 && line[idx] == 'k' && line[idx + 1] == 'a') idx += 2;
                else if (idx + 2 <= line.Length - 1 && line[idx] == 'c' && line[idx + 1] == 'h' && line[idx + 2] == 'u') idx += 3;
                else break;
                if (idx == line.Length) break;
            }

            if(idx != line.Length) Console.Write("NO");
            else Console.Write("YES");
        }
    }
}
