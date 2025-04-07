namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_21185
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string answer = "Either";
            if (n % 2 == 0)
            {
                //n == 6, (2,3,4,5,6,7)
                if((n / 2) % 2 == 1) answer = "Odd";
                else answer = "Even";
            }

            Console.Write(answer);
        }
    }
}
