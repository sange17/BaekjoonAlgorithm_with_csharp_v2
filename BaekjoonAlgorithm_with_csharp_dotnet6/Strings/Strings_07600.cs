namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_07600
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string line = sr.ReadLine()!;
                if (line == "#")
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                char[] array = line.ToCharArray();
                int[] alphaArr = new int[26];

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 65 && array[i] <= 90)
                    {
                        alphaArr[array[i] - 65]++;
                    }
                    else if (array[i] >= 97 && array[i] <= 122)
                    {
                        alphaArr[array[i] - 97]++;
                    }
                }

                sw.WriteLine(alphaArr.Where(x => x > 0).Count());
            }
        }
    }
}
