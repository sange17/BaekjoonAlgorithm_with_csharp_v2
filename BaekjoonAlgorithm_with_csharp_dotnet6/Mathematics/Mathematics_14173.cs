namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_14173
    {
        public void solve()
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;

            for (int i = 0; i < 2; i++)
            {
                string[] inputs = Console.ReadLine()!.Split(' ');
                int x1 = int.Parse(inputs[0]);
                int y1 = int.Parse(inputs[1]);
                int x2 = int.Parse(inputs[2]);
                int y2 = int.Parse(inputs[3]);

                minX = Math.Min(minX, x1);
                minY = Math.Min(minY, y1);
                maxX = Math.Max(maxX, x2);
                maxY = Math.Max(maxY, y2);
            }

            int side = Math.Max(maxX - minX, maxY - minY);
            Console.Write((side) * (side));
        }
    }
}
