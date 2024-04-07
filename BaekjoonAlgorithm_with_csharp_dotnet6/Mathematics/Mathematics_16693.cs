namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_16693
    {
        public void solve()
        {
            string line = Console.ReadLine();
            double a = double.Parse(line.Split(" ")[0]);
            double p = double.Parse(line.Split(" ")[1]);
            line = Console.ReadLine();
            double r = double.Parse(line.Split(" ")[0]);
            double q = double.Parse(line.Split(" ")[1]);

            double x = a / p;
            double y = Math.PI * r * r / q;
            if(x < y)
                Console.Write("Whole pizza");
            else
                Console.Write("Slice of pizza");
        }
    }
}
