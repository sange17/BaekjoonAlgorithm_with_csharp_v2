namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_09884
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int A = array[0];
            int B = array[1];

            while (true)
            {
                if (A == B)
                {
                    Console.Write(B);
                    break;
                }

                int temp = A;
                A = Math.Max(A, B) - Math.Min(A, B);
                B = Math.Min(temp, B);
            }
        }
    }
}
