namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24356
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int mAllTime = 24 * 60;
            int mTime1 = (array[0] * 60) + array[1];
            int mTime2 = (array[2] * 60) + array[3];
            int mMinTime = 0;

            if (mTime1 > mTime2)
                mMinTime = mAllTime - mTime1 + mTime2;
            else
                mMinTime = mTime2 - mTime1;

            Console.Write(mMinTime + " " + (mMinTime / 30));
        }
    }
}
