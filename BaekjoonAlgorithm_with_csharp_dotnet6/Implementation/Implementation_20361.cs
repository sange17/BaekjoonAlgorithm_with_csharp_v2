namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_20361
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int n = inputs[0];
            int x = inputs[1];
            int k = inputs[2];

            string line = string.Empty;
            int a = 0, b = 0;
            int result = x;

            for (int i = 0; i < k; i++)
            {
                line = Console.ReadLine()!;
                a = Int32.Parse(line.Split(" ")[0]);
                b = Int32.Parse(line.Split(" ")[1]);

                if (a != result && b != result) continue;

                if (result == a) result = b;
                else if(result == b) result = a;
            }

            Console.Write(result);
        }
    }
}
