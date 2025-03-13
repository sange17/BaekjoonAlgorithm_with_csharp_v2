namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_13363
    {
        public void solve()
        {
            int n1 = Int32.Parse(Console.ReadLine()!);
            int n2 = Int32.Parse(Console.ReadLine()!);
            int result = n2 - n1;

            if (result > 100)
                Console.Write(result - 360);
            else if (result <= -100)
                Console.Write(result + 360);
        }
    }
}
