namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_02703
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < T; i++)
            {
                string msgLine = sr.ReadLine()!;
                char[] ruleArr = sr.ReadLine()!.ToCharArray();

                for (int j = 0; j < msgLine.Length; j++)
                {
                    if(msgLine[j] == ' ')
                        sw.Write(' ');
                    else
                        sw.Write(ruleArr[msgLine[j] - 65]);
                }
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
