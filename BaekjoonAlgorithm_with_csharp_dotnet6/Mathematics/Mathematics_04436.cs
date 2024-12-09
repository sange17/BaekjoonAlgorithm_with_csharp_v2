namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04436
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string line = sr.ReadLine()!;
                bool[] array = new bool[10];

                if(string.IsNullOrEmpty(line))
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                int count = 0;
                int idx = 1;
                long num = long.Parse(line);
                while (true)
                {
                    if (!array.Contains(false))
                    {
                        sw.WriteLine(count);
                        break;
                    }

                    string temp = (num * idx).ToString();
                    for (int i = 0; i < temp.Length; i++)
                    {
                        array[temp[i] - 48] = true;
                    }

                    count++;
                    idx++;
                }
            }
        }
    }
}
