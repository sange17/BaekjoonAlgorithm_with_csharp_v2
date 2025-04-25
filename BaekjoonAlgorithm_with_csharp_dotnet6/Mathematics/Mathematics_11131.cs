namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11131
    {
        public void solve()
        {
            int t = Int32.Parse(Console.ReadLine()!);
            for (int i = 0; i < t; i++)
            {
                int n = Int32.Parse(Console.ReadLine()!);
                int[] w = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                int torque = 0;
                for (int j = 0; j < n; j++)
                    torque += 100 * w[j];

                if (torque == 0) Console.WriteLine("Equilibrium");
                else if (torque > 0) Console.WriteLine("Right");
                else Console.WriteLine("Left");
            }
        }
    }
}
