namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_05698
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string line = sr.ReadLine()!.ToLower();
                if(line == "*")
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                string[] array = line.Split(" ");
                int count = array.Where(x => x[0] == line[0]).Count();
                if (count == array.Length) sw.WriteLine("Y");
                else sw.WriteLine("N");
            }
        }
    }
}
