namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_33651
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line1 = sr.ReadLine()!;
            char[] array1 = line1.ToCharArray();
            string line2 = "UAPC";

            for (int i = 0; i < line2.Length; i++)
            {
                if (!line1.Contains(line2[i]))
                    sw.Write(line2[i]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
