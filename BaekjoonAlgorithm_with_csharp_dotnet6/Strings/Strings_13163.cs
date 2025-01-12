namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_13163
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < N; i++)
            {
                string[] array = sr.ReadLine()!.Split(" ");

                array[0] = "god";

                sw.WriteLine(string.Join("", array));
            }

            sr.Close();
            sw.Close();
        }
    }
}
