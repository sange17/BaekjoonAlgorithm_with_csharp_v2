namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_31654
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int a = Int32.Parse(line.Split(" ")[0]);
            int b = Int32.Parse(line.Split(" ")[1]);
            int c = Int32.Parse(line.Split(" ")[2]);

            if(a + b == c)
                Console.Write("correct!");
            else
                Console.Write("wrong!");
        }
    }
}
