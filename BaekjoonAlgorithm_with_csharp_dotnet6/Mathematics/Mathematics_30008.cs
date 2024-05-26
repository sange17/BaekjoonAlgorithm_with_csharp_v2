namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_30008
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string[] line = sr.ReadLine().Split();
            int n = Int32.Parse(line[0]);
            int k = Int32.Parse(line[1]);

            line = sr.ReadLine().Split(" ");
            for (int i = 0; i < k; i++)
            {
                int p = Int32.Parse(line[i]) * 100 / n;
                if (0 <= p && p <= 4)
                    sw.Write(1);
                else if (4 < p && p <= 11)
                    sw.Write(2);
                else if (11 < p && p <= 23)
                    sw.Write(3);
                else if (23 < p && p <= 40)
                    sw.Write(4);
                else if (40 < p && p <= 60)
                    sw.Write(5);
                else if (60 < p && p <= 77)
                    sw.Write(6);
                else if (77 < p && p <= 89)
                    sw.Write(7);
                else if (89 < p && p <= 96)
                    sw.Write(8);
                else if (96 < p && p <= 100)
                    sw.Write(9);

                if (i != k - 1)
                    sw.Write(" ");
            }

            sr.Close();
            sw.Close();
        }
    }
}
