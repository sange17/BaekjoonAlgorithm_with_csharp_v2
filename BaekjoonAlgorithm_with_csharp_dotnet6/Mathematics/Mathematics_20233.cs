namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_20233
    {
        public void solve()
        {
            int a = Int32.Parse(Console.ReadLine());
            int x = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            int T = Int32.Parse(Console.ReadLine());

            if(T <= 30)
            {
                Console.Write(a + " " + b);
            } 
            else if(T > 30 && T <= 45)
            {
                Console.Write((a + (T - 30) * x * 21) + " " + b);
            }
            else if(T > 45)
            {
                Console.Write((a + (T - 30) * x * 21) + " " + (b + (T - 45) * y * 21));
            }
        }
    }
}
