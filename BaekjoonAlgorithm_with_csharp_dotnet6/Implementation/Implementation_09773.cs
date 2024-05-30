using System.Xml.XPath;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09773
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string line = sr.ReadLine();

                int sum = 0;
                int result = 0;
                for (int j = 0; j < 13; j++)
                {
                    sum += (line[j] - 48);
                }

                result = sum + Int32.Parse(line.Substring(10, 3)) * 10;

                if (result < 1000)
                    sw.WriteLine(result + 1000);
                else if (result > 9999)
                    sw.WriteLine(result.ToString().Substring(1, 4));
                else
                    sw.WriteLine(result);
            }

            sr.Close();
            sw.Close();
        }
    }
}
