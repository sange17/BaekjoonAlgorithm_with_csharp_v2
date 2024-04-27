namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_31403
    {
        public void solve()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine(a + b - c);
            Console.Write(Int32.Parse(a.ToString() + b.ToString()) - c);
        }
    }
}
