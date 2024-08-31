namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_24333
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int l1 = Int32.Parse(line.Split(" ")[0]);
            int r1 = Int32.Parse(line.Split(" ")[1]);
            int l2 = Int32.Parse(line.Split(" ")[2]);
            int r2 = Int32.Parse(line.Split(" ")[3]);
            int k = Int32.Parse(line.Split(" ")[4]);

            bool[] array1 = new bool[50001];
            bool[] array2 = new bool[50001];
            for(int i = l1; i <= r1; i++) array1[i] = true;
            for(int i = l2; i <= r2; i++) array2[i] = true;

            int count = 0;
            for (int i = 0; i < 50001; i++)
            {
                if (array1[i] && array2[i])
                {
                    if(i != k) count++;
                }
            }

            Console.Write(count);
        }
    }
}
