namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25591
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int num1 = Int32.Parse(line.Split(" ")[0]);
            int num2 = Int32.Parse(line.Split(" ")[1]);

            int a = 100 - num1;
            int b = 100 - num2;
            int c = 100 - (a + b);
            int d = a * b;
            int q = d / 100;
            int r = d % 100;
            int front = q;
            int back = r;

            if (d > 99) front = c + q;
            else front = c;
            
            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + q + " " + r);
            Console.Write(front + " " + back);
        }
    }
}
