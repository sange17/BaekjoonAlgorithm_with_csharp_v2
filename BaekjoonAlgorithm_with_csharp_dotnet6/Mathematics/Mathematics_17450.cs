namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_17450
    {
        // test
        public void solve()
        {
            string result = string.Empty;
            double max = 0;
            string[] array = { "S", "N", "U" };

            for (int i = 0; i < 3; i++)
            {
                string inputs = Console.ReadLine()!;
                double P = double.Parse(inputs.Split(" ")[0]) * 10;
                double W = double.Parse(inputs.Split(" ")[1]) * 10;

                if (P >= 5000) P -= 500;

                if (max < W / P)
                {
                    max = W / P;
                    result = array[i];
                }
            }

            Console.Write(result);
        }
    }
}
