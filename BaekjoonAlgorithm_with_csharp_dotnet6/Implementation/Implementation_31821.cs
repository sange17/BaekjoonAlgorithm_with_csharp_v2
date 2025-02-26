namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_31821
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int[] array = new int[N];
            
            for (int i = 0; i < N; i++)
                array[i] = Int32.Parse(Console.ReadLine()!);
            
            int M = Int32.Parse(Console.ReadLine()!);
            int sum = 0;
            
            for(int i = 0; i < M; i++)
                sum += array[Int32.Parse(Console.ReadLine()!) - 1];

            Console.Write(sum);
        }
    }
}
