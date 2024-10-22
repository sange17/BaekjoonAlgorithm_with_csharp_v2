namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01252
    {
        public void solve()
        {
            string[] array = Console.ReadLine()!.Split(" ");

            Console.WriteLine(Convert.ToString(Convert.ToUInt32(array[0]) + Convert.ToUInt32(array[1]),2));
        }
    }
}
