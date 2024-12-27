namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_06766
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int K = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;

            for (int i = 0; i < line.Length; i++)
            {
                int alphabet = line[i] - (3 * (i + 1) + K);
                if (alphabet < 65)
                    alphabet = 91 - (65 - alphabet);

                sw.Write((char)alphabet);
            }

            sr.Close();
            sw.Close();
        }
    }
}
