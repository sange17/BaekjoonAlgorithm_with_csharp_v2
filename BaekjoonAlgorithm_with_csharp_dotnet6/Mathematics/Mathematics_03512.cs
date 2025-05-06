namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_03512
    {
        public void solve()
        {
            string inputs = Console.ReadLine()!;
            decimal n = Int32.Parse(inputs.Split(" ")[0]);
            decimal c = Int32.Parse(inputs.Split(" ")[1]);
            decimal sum1 = 0;
            decimal sum2 = 0;
            decimal sum3 = 0;

            for (int i = 0; i < n; i++)
            {
                inputs = Console.ReadLine()!;
                decimal a = Int32.Parse(inputs.Split(" ")[0]);
                string t = inputs.Split(" ")[1];

                if (t == "balcony")
                {
                    sum1 += a;
                    sum3 += (c * a / 2);
                }
                else if(t == "bedroom")
                {
                    sum1 += a;
                    sum2 += a;
                    sum3 += (c * a);
                }
                else
                {
                    sum1 += a;
                    sum3 += (c * a);
                }
            }

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.Write(sum3);
        }
    }
}
