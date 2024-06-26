namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_17912
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(" ");
            int min = int.MaxValue;
            int result = 0;
            
            for(int i = 0; i < n; i++)
            {
                if (min > Int32.Parse(array[i]))
                {
                    min = Int32.Parse(array[i]);
                    result = i;
                }
            }

            Console.Write(result);
        }
    }
}
