namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_11795
    {
        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine()!);
            int setA = 0;
            int setB = 0;
            int setC = 0;
            for (int i = 0; i < T; i++)
            {
                int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                setA += array[0];
                setB += array[1];
                setC += array[2];

                int packages = Math.Min(Math.Min(setA, setB), setC);
                if(packages < 30) Console.WriteLine("NO");
                else
                {
                    Console.WriteLine(packages);
                    setA -= packages;
                    setB -= packages;
                    setC -= packages;
                }
            }
        }
    }
}
