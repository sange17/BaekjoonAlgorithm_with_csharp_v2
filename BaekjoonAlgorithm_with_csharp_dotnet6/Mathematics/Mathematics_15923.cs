namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_15923
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            int sx = Int32.Parse(line.Split(" ")[0]); 
            int sy = Int32.Parse(line.Split(" ")[1]);
            int x = sx;
            int y = sy;
            int nx = 0;
            int ny = 0;
            int ans = 0;

            for(int i = 0; i < n - 1; i++)
            {
                line = Console.ReadLine();
                nx = Int32.Parse(line.Split(" ")[0]);
                ny = Int32.Parse(line.Split(" ")[1]);

                ans += Math.Abs(nx + ny - x - y);
                x = nx;
                y = ny;
            }

            ans += Math.Abs(x + y - sx - sy);
            Console.Write(ans);
        }
    }
}
