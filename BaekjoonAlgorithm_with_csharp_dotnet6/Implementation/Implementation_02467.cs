namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02467
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            long[] array =  new long[n];

            string[] strings = Console.ReadLine().Split(" ");
            for(int i = 0; i < n; i++)
            {
                array[i] = long.Parse(strings[i]);
            }

            long min = long.MaxValue;
            int ml = 0;
            int mr = 0;
            for(int i = 0; i < n - 1; i++)
            {
                int left = i + 1;
                int right = n - 1;
                while(left <= right)
                {
                    int mid = (left + right) / 2;
                    long sum = Math.Abs(array[i] + array[mid]);

                    if(min > sum)
                    {
                        min = sum;
                        ml = i;
                        mr = mid;
                    }
                    if (array[mid] >= -array[i])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }
            Console.Write(array[ml] + " " + array[mr]);
        }
    }
}

//투 포인터 풀이
//public void solve()
//{
//    int N = Int32.Parse(Console.ReadLine());
//    long[] array1 = new long[N];
//    string[] array2 = Console.ReadLine().Split(" ");
//    for (int i = 0; i < N; i++)
//    {
//        array1[i] = long.Parse(array2[i]);
//    }

//    int left = 0;
//    int right = N - 1;
//    int ml = 0;
//    int mr = 0;
//    long min = long.MaxValue;
//    while (left < right)
//    {
//        long sum = array1[left] + array1[right];
//        if (min > Math.Abs(sum))
//        {
//            min = Math.Abs(sum);
//            ml = left;
//            mr = right;
//        }
//        if (sum >= 0)
//            right--;
//        else
//            left++;
//    }
//    Console.Write(array1[ml] + " " + array1[mr]);
//}
