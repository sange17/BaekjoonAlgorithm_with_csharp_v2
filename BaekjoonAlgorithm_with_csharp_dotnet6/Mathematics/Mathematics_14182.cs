namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_14182
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int tax = Int32.Parse(Console.ReadLine());

                if(tax == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                if (tax < 1000000)
                    sw.WriteLine(tax);
                else if (tax > 1000000 && tax <= 5000000)
                    sw.WriteLine(tax - tax * 10 / 100);
                else if (tax > 5000000)
                    sw.WriteLine(tax - tax * 20 / 100);
            }
        }
    }
}
