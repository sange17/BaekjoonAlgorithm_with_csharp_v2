namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_30067
    {
        public void solve()
        {
            int sum = 0;
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int num = Int32.Parse(Console.ReadLine());
                arr[i] = num;
                sum += num;
            }

            for (int i = 0; i < 10; i++)
            {
                if (arr[i] * 2 == sum)
                {
                    Console.Write(arr[i]);
                    return;
                }
            }
        }
    }
}
