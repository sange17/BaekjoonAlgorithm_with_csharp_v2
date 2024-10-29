namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_01718
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine()!;
            string key = sr.ReadLine()!;

            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (count == key.Length) count = 0;

                if (line[i] == ' ')
                {
                    sw.Write(line[i]);
                }
                else
                {
                    // a 앞 문자인 경우
                    // (z + 1) - (a 앞 n번째 순서)
                    if (line[i] - (key[count] - 96) < 97)
                    {
                        sw.Write((char)(123 - (97 - (line[i] - (key[count] - 96)))));
                    }
                    // a 앞 문자가 아닌 경우
                    // (평문 문자 아스키 코드 값) - (알파벳 key 문자의 순서)
                    else
                    {
                        sw.Write((char)(line[i] - (key[count] - 96)));
                    }
                }

                count++;
            }

            sr.Close();
            sw.Close();
        }
    }
}
