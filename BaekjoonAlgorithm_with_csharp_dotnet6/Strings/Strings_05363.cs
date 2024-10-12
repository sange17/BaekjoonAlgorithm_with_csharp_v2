namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_05363
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < N; i++)
            {
                string[] array = sr.ReadLine()!.Split(" ");

                for (int j = 2; j < array.Length; j++)
                {
                    sw.Write(array[j] + " ");
                }

                sw.Write(array[0] + " " + array[1]);
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
