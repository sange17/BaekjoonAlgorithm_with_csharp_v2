using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_05603
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()! + "X";

            for (int i = 0; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();
                int count = 1;  //같은 수의 개수
                for (int j = 0; j < line.Length - 1; j++)
                {
                    if (line[j] == line[j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        sb.Append(count + "" + line[j]);
                        count = 1;
                    }

                }

                line = sb.ToString() + "X";
            }

            Console.WriteLine(line.Substring(0, line.Length - 1));
        }
    }
}
