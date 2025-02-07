using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31495
    {
        public void solve()
        {
            StringBuilder sb = new StringBuilder();

            string line = Console.ReadLine()!;
            bool flag = false;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '"')
                {
                    int idx = i + 1;
                    while (true)
                    {
                        if (line.Length - 1 < idx)
                        {
                            flag = true;
                            break;
                        }

                        sb.Append(line[idx]);
                        idx++;
                    }
                }

                if (flag) break;
            }

            string result = sb.ToString();
            if(!result.Contains("\"") 
                || result == "\"" 
                || result.Where(x => x == ' ').Count() == result.Length - 1)
                Console.Write("CE");
            else
                Console.Write(result.Split("\"")[0]);
        }
    }
}
