namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_04072
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string line = sr.ReadLine()!;

                if (line == "#") break;

                string[] array = new string(line.Reverse().ToArray()).Split(" "); ;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    sw.Write(array[i] + " ");
                }

                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
