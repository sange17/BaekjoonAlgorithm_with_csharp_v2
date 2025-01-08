namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_05365
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);
            string[] array = sr.ReadLine()!.Split(" ");

            sw.Write(array[0][0]);
            for (int i = 1; i < N; i++)
            {
                if (array[i].Length < array[i - 1].Length)
                    sw.Write(" ");
                else
                    sw.Write(array[i][array[i - 1].Length - 1]);

            }

            sr.Close();
            sw.Close();
        }
    }
}
