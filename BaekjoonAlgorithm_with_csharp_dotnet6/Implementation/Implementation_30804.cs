namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_30804
    {
        static int n = 0;
        static int[] array = new int[n];
        static int[] nums = new int[10];

        static int twoPointer(int left, int right, int cnt, int kind, int max)
        {
            if (right >= n) return max;

            if (nums[array[right]] == 0) kind++;

            cnt++;
            nums[array[right]]++;

            if (kind > 2)
            {
                if (--nums[array[left]] == 0) kind--;

                cnt--;
                left++;
            }

            max = Math.Max(max, cnt);

            return twoPointer(left, right + 1, cnt, kind, max);
        }

        public void solve()
        {
            n = Int32.Parse(Console.ReadLine()!);
            array = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Console.Write(twoPointer(0, 0, 0, 0, 0));
        }
    }
}
