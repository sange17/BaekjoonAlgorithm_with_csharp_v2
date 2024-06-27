namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_15429
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());

            string[] array;
            for (int i = 0; i < n; i++)
            {
                array = sr.ReadLine().Split(" ");

                for (int j = 2; j <= Int32.Parse(array[0]) - 1; j++)
                {
                    int before = Int32.Parse(array[j - 1]);
                    int curr = Int32.Parse(array[j]);
                    int after = Int32.Parse((array[j + 1]));
                    if (curr - before != 1 && after - curr == 1)
                    {
                        sw.WriteLine(before);
                        break;
                    }
                    else if (curr - before == 1 && after - curr != 1)
                    {
                        sw.WriteLine(after);
                        break;
                    }
                }

                sr.Close();
                sw.Close();
            }
        }
    }
}
