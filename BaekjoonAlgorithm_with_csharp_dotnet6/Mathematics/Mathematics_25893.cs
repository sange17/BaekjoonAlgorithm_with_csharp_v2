namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25893
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string line = sr.ReadLine();
                int a = Int32.Parse(line.Split(" ")[0]);
                int b = Int32.Parse(line.Split(" ")[1]);
                int c = Int32.Parse(line.Split(" ")[2]);

                if(a >= 10 && b >= 10 && c >= 10)
                {
                    sw.WriteLine(a + " " + b + " " + c);
                    sw.WriteLine("triple-double");
                }
                else if((a >= 10 && b >= 10 && c < 10)
                      ||(a >= 10 && b < 10 && c >= 10)
                      ||(a < 10 && b >= 10 && c >= 10))
                {
                    sw.WriteLine(a + " " + b + " " + c);
                    sw.WriteLine("double-double");
                }
                else if((a >= 10 && b < 10 && c < 10)
                      ||(a < 10 && b >= 10 && c < 10)
                      ||(a < 10 && b < 10 && c >= 10))
                {
                    sw.WriteLine(a + " " + b + " " + c);
                    sw.WriteLine("double");
                }
                else if(a < 10 && b < 10 && c < 10)
                {
                    sw.WriteLine(a + " " + b + " " + c);
                    sw.WriteLine("zilch");
                }

                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
