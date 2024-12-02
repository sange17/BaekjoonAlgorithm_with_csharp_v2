namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04118
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int n = Int32.Parse(sr.ReadLine()!);
                int[] array = new int[50];
                array[0] = 1;

                if (n == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                for (int i = 0; i < n; i++)
                {
                    int[] inputArr = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

                    for (int j = 0; j < 6; j++)
                        array[inputArr[j]] = 1;
                }

                if (array.Contains(0))
                    sw.WriteLine("No");
                else
                    sw.WriteLine("Yes");
            }
        }
    }
}
