namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_18698
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                string[] array = sr.ReadLine()!.Split("D");

                sw.WriteLine(array[0].Length);
            }

            sr.Close();
            sw.Close();
        }
    }
}
