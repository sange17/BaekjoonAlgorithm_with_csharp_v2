namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_29807
    {
        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int result = 0;
            if (T == 1)
            {
                sum1 = array[0] * 508;
            }
            else if (T == 2)
            {
                sum1 = array[0] * 508;
                sum2 = array[1] * 212;
            }
            else if(T == 3)
            {
                if (array[0] > array[2])
                    sum1 = (array[0] - array[2]) * 508;
                else
                    sum1 = (array[2] - array[0]) * 108;
                sum2 = array[1] * 212;
            }
            else if (T == 4)
            {
                if (array[0] > array[2])
                    sum1 = (array[0] - array[2]) * 508;
                else
                    sum1 = (array[2] - array[0]) * 108;
                if (array[1] > array[3])
                    sum2 = (array[1] - array[3]) * 212;
                else
                    sum2 = (array[3] - array[1]) * 305;
            }

            else if (T == 5)
            {
                if (array[0] > array[2])
                    sum1 = (array[0] - array[2]) * 508;
                else
                    sum1 = (array[2] - array[0]) * 108;
                if (array[1] > array[3])
                    sum2 = (array[1] - array[3]) * 212;
                else
                    sum2 = (array[3] - array[1]) * 305;

                sum3 = array[4] * 707;
            }

            result = (sum1 + sum2 + sum3) * 4763;
            Console.Write(result);
        }
    }
}
