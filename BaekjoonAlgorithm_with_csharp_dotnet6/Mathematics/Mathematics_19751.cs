namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_19751
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Array.Sort(array);

            Console.WriteLine(array[0] + " " + array[2] + " " + array[1] + " " + array[3]);
        }
    }
}
