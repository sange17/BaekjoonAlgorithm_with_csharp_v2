namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04696
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            decimal num = 0;
            decimal sum = 0;

            while (true)
            {
                num = decimal.Parse(sr.ReadLine()!);
                sum = 1 + num + (num * num) + (num * num * num) + (num * num * num * num);

                if(num == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }
                else
                {
                    sw.WriteLine("{0:f2}", sum);
                }
            }
        }
    }
}
