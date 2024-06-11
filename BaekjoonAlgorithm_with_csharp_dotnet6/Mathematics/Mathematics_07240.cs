namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_07240
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(" ")[0]);
            int S = Int32.Parse(line.Split(" ")[1]);

            int sum = 0;
            for(int i = 0; i < N; i++) 
            {
                if (sum > S) sum -= 1;

                sum += Int32.Parse(Console.ReadLine());
            }

            Console.Write(sum);
        }
    }
}
