namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01392
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inArray = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            List<int> sheetMusic = new List<int>();

            for (int i = 1; i <= inArray[0]; i++)
            {
                int time = Int32.Parse(sr.ReadLine()!);
                for (int j = 0; j < time; j++)
                {
                    sheetMusic.Add(i);
                }
            }

            for (int i = 0; i < inArray[1]; i++)
            {
                int question = int.Parse(sr.ReadLine()!);
                sw.WriteLine(sheetMusic[question]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
